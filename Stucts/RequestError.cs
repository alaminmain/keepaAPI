using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// Contains information about an API error.
    /// </summary>
    public class RequestError
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

        /// <summary>
        /// Converts the error object into a JSON-formatted string.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
