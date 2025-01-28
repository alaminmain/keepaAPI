using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KeepaApiBackend.Controllers
{
    [ApiController]
    [Route("api/keepa")]
    public class KeepaApiController : ControllerBase
    {
        private readonly string _accessKey;
        private readonly string _userAgent = "KEEPA-CSharp-API";
        private const int MaxDelay = 60000;

        public KeepaApiController()
        {
            _accessKey = "your_api_key"; // Replace with your actual Keepa API Key
        }

        public enum ResponseStatus
        {
            PENDING, OK, FAIL, NOT_ENOUGH_TOKEN, REQUEST_REJECTED, PAYMENT_REQUIRED, METHOD_NOT_ALLOWED, INTERNAL_SERVER_ERROR
        }

        [HttpPost("sendRequest")]
        public async Task<IActionResult> SendRequest([FromBody] KeepaRequest request)
        {
            if (request == null) return BadRequest("Invalid request payload.");

            var response = await ProcessRequest(request);
            return response.Status == ResponseStatus.OK ? Ok(response) : StatusCode((int)HttpStatusCode.BadRequest, response);
        }

        private async Task<KeepaResponse> ProcessRequest(KeepaRequest request, int connectTimeout = 30000, int readTimeout = 120000)
        {
            var response = new KeepaResponse();
            var query = request.Parameter != null
                ? string.Join("&", request.Parameter.Select(p => $"{WebUtility.UrlEncode(p.Key)}={WebUtility.UrlEncode(p.Value)}"))
                : "";

            string url = $"https://api.keepa.com/{request.Path}?key={_accessKey}&{query}";

            try
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.UserAgent = _userAgent;
                webRequest.Timeout = connectTimeout;
                webRequest.Headers.Add("Accept-Encoding", "gzip");

                if (!string.IsNullOrEmpty(request.PostData))
                {
                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/json; charset=UTF-8";
                    using var streamWriter = new StreamWriter(webRequest.GetRequestStream());
                    await streamWriter.WriteAsync(request.PostData);
                }
                else
                {
                    webRequest.Method = "GET";
                }

                using var webResponse = (HttpWebResponse)await webRequest.GetResponseAsync();
                response = await ProcessResponse(webResponse);
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse httpResponse)
                {
                    response = await ProcessResponse(httpResponse);
                }
                else
                {
                    response.Status = ResponseStatus.FAIL;
                    response.ErrorMessage = ex.Message;
                }
            }

            return response;
        }

        private async Task<KeepaResponse> ProcessResponse(HttpWebResponse webResponse)
        {
            var response = new KeepaResponse();
            try
            {
                using var responseStream = webResponse.GetResponseStream();
                using var decompressionStream = new GZipStream(responseStream, CompressionMode.Decompress);
                using var streamReader = new StreamReader(decompressionStream);
                var jsonResponse = await streamReader.ReadToEndAsync();
                response = JsonSerializer.Deserialize<KeepaResponse>(jsonResponse);
                response.Status = ResponseStatus.OK;
            }
            catch (Exception ex)
            {
                response.Status = ResponseStatus.FAIL;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }

    public class KeepaRequest
    {
        public string Path { get; set; }
        public Dictionary<string, string> Parameter { get; set; }
        public string PostData { get; set; }
    }

    public class KeepaResponse
    {
        [JsonPropertyName("status")]
        public KeepaApiController.ResponseStatus Status { get; set; } = KeepaApiController.ResponseStatus.PENDING;

        [JsonPropertyName("error")]
        public string ErrorMessage { get; set; }
    }
}
