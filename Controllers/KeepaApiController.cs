using System.IO.Compression;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using keepaAPI.Structs;
using Microsoft.AspNetCore.Mvc;
using Polly;
using Polly.Extensions.Http;
using Polly.Retry;

namespace KeepaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KeepaApiController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;

        public KeepaApiController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;

            // Define Polly Retry Policy (3 retries with exponential backoff)
            _retryPolicy = HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        }

        [HttpPost("send-request")]
        public async Task<IActionResult> SendRequest([FromBody] KeepaRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Path))
                return BadRequest("Invalid request payload.");

            string apiKey = _configuration["KeepaApiKey"]; // Load API Key from config
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
                    httpRequest.Content = new StringContent(JsonSerializer.Serialize(request.PostData), Encoding.UTF8, "application/json");
                }

                HttpResponseMessage response = await _retryPolicy.ExecuteAsync(() => _httpClient.SendAsync(httpRequest));

                if (!response.IsSuccessStatusCode)
                {
                    return StatusCode((int)response.StatusCode, $"Error: {response.ReasonPhrase}");
                }

                var responseData = await DecompressResponse(response);
                var keepaResponse = JsonSerializer.Deserialize<KeepaResponse>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

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
            var codeList = codes.Split(',');
            var tasks = new List<Task<HttpResponseMessage>>();

            foreach (var code in codeList)
            {
                var url = $"https://api.keepa.com/product?key=k2hvuj5pni54jdq9t1qcchq9hq67gfv944qfu6mo17ltel0egs2siub39nhga0ot&domain=1&code={code}&history=0&days=1&offers=20";
                tasks.Add(_httpClient.GetAsync(url));
            }

            var responses = await Task.WhenAll(tasks);
            var productResponses = new List<ProductResponse>();

            foreach (var response in responses)
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var productResponse = JsonSerializer.Deserialize<ProductResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    productResponses.Add(productResponse);
                }
            }

            return Ok(productResponses);
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
        public object? Products { get; set; }
        public object? Categories { get; set; }
        public object? Error { get; set; }
        public object? Additional { get; set; }
    }
}
