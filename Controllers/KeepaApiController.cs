
using keepaAPI.DBContext;
using keepaAPI.Helper;
using keepaAPI.Structs;
using keepaAPI.Structs.ProductRawClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;
using System.IO.Compression;
using System.Text;
using System.Text.Json;

namespace KeepaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KeepaApiController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;
        private readonly KeepaDbContext _dbContext;
        public KeepaApiController(IHttpClientFactory httpClientFactory, IConfiguration configuration, KeepaDbContext dbContext)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;

            // Define Polly Retry Policy (3 retries with exponential backoff)
            _retryPolicy = HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
            _dbContext = dbContext;
        }

        [HttpPost("send-request")]
        public async Task<IActionResult> SendRequest([FromBody] KeepaRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Path))
                return BadRequest("Invalid request payload.");

            string apiKey = _configuration["Keepa:ApiKey"]; // Load API Key from config
            if (string.IsNullOrEmpty(apiKey))
                return StatusCode(500, "API key is missing.");

            string queryParams = string.Join("&", request.Parameters.Select(p => $"{Uri.EscapeDataString(p.Key)}={Uri.EscapeDataString(p.Value)}"));
            string url = $"https://api.keepa.com/{request.Path}?key={apiKey}&{queryParams}";

            try
            {
                HttpRequestMessage httpRequest = new HttpRequestMessage
                {
                    Method = request.PostData != null ? HttpMethod.Post : HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Headers =
                    {
                        { "User-Agent", "Keepa-DotNet-Client" },
                        { "Accept-Encoding", "gzip" }
                    }
                };

                if (request.PostData != null)
                {
                    httpRequest.Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(request.PostData), Encoding.UTF8, "application/json");
                }

                HttpResponseMessage response = await _retryPolicy.ExecuteAsync(() => _httpClient.SendAsync(httpRequest));

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, $"Error: {response.ReasonPhrase}");
                }

                var responseData = await DecompressResponse(response);
                var keepaResponse = System.Text.Json.JsonSerializer.Deserialize<Response>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return Ok(keepaResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts([FromQuery] string codes)
        {
            string apiKey = _configuration["Keepa:ApiKey"];
            if (string.IsNullOrEmpty(apiKey))
                return StatusCode(500, "API key is missing.");

            // Check if the product is already in the database
            var existingProduct = await _dbContext.Products
                .Include(p => p.UpcList)
                .Include(p => p.EanList)
                .Include(p => p.Variations)
                .FirstOrDefaultAsync(p => p.Asin == codes);

            if (existingProduct != null)
            {
                return Ok(existingProduct);
            }

            var url = $"https://api.keepa.com/product?key={apiKey}&domain=1&code={codes}&offers=20&history=0&days=1&stats=1";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, $"Error: {response.ReasonPhrase}");
            }

            var contentType = response.Content.Headers.ContentType?.MediaType;
            if (contentType != "application/json")
            {
                var contentFallback = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Unexpected Content Type: {contentType}");
                Console.WriteLine($"Response: {contentFallback}");
                return StatusCode((int)response.StatusCode, "Invalid response format received from Keepa.");
            }

            string content;
            try
            {
                List<ProductForBrandTrader> products = new List<ProductForBrandTrader>();
                var contentStream = await response.Content.ReadAsStreamAsync();
                using (var decompressedStream = new GZipStream(contentStream, CompressionMode.Decompress))
                using (var reader = new StreamReader(decompressedStream))
                {
                    content = await reader.ReadToEndAsync();
                }

               

                using (JsonDocument document = JsonDocument.Parse(content))
                {
                    var root = document.RootElement;

                   
                    

                    if (root.TryGetProperty("products", out JsonElement productsElement))
                    {
                        var productsJson = productsElement.GetRawText();
                        //var products = JsonSerializer.Deserialize<List<ProductForBrandTrader>>(productsJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                        var myDeserializedClass = System.Text.Json.JsonSerializer.Deserialize<KeepaResponseObj>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ;

                        if (myDeserializedClass == null)
                        {
                            return StatusCode(500, "Expected 'products' property not found in the response.");
                        }

                        foreach (var product in myDeserializedClass.Products)
                        {
                            ProductForBrandTrader productForBrandTrader = new ProductForBrandTrader();


                            productForBrandTrader=ProductMapper.MapToProductForBrandTrader(product);
                            products.Add(productForBrandTrader);

                        }
                        // Save the products to the database
                        _dbContext.Products.AddRange(products);
                        await _dbContext.SaveChangesAsync();

                        return Ok();
                    }
                    else
                    {
                        return StatusCode(500, "Expected 'products' property not found in the response.");
                    }
                }
            }
            catch (System.Text.Json.JsonException ex)
            {
                return StatusCode(500, $"JSON Parsing Error: {ex.Message}");
            }
        }

        private async Task<string> DecompressResponse(HttpResponseMessage response)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();
            using var decompressionStream = new GZipStream(responseStream, CompressionMode.Decompress);
            using var reader = new StreamReader(decompressionStream, Encoding.UTF8);
            return await reader.ReadToEndAsync();
        }
    }

    public class KeepaRequest
    {
        public string Path { get; set; } = "";
        public Dictionary<string, string> Parameters { get; set; } = new();
        public object? PostData { get; set; }
    }

    public class KeepaResponse
    {
        public long Timestamp { get; set; }
        public int TokensLeft { get; set; }
        public int RefillIn { get; set; }
        public int RefillRate { get; set; }
        public long RequestTime { get; set; }
        public int ProcessingTimeInMs { get; set; }
        public double TokenFlowReduction { get; set; }
        public int TokensConsumed { get; set; }
        public string Status { get; set; } = "PENDING";
        public List<keepaAPI.Structs.Product>? Products { get; set; }
        public List<keepaAPI.Structs.Category>? Categories { get; set; }
        public List<keepaAPI.Structs.RequestError>? Error { get; set; }
        public object? Additional { get; set; }
    }
}
