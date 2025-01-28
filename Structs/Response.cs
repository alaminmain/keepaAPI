using System;
using System.Collections.Generic;
using keepaAPI.Helper.Enum;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Common Keepa API Response
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Server time when the response was sent.
        /// </summary>
        public long Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        /// <summary>
        /// States how many ASINs may be requested before the assigned API quota is depleted.
        /// If the quota is depleted, HTTP status code 503 will be delivered with the message:
        /// "You are submitting requests too quickly and your requests are being throttled."
        /// </summary>
        public int TokensLeft { get; set; } = 0;

        /// <summary>
        /// Milliseconds until new tokens are generated.
        /// Use this if your quota is depleted to wait before you try a new request. 
        /// Tokens are generated every 5 minutes.
        /// </summary>
        public int RefillIn { get; set; } = 0;

        /// <summary>
        /// Token refill rate per minute.
        /// </summary>
        public int RefillRate { get; set; } = 0;

        /// <summary>
        /// Total time the request took (local, including latencies and connection establishment), in milliseconds.
        /// </summary>
        public long RequestTime { get; set; } = 0;

        /// <summary>
        /// Time the request's processing took (remote), in milliseconds.
        /// </summary>
        public int ProcessingTimeInMs { get; set; } = 0;

        /// <summary>
        /// Token flow reduction.
        /// </summary>
        public double TokenFlowReduction { get; set; } = 0;

        /// <summary>
        /// Tokens used for this call.
        /// </summary>
        public int TokensConsumed { get; set; } = 0;

        /// <summary>
        /// Status of the request.
        /// </summary>
        public ResponseStatus Status { get; set; } = ResponseStatus.PENDING;

        /// <summary>
        /// Results of the product request.
        /// </summary>
        public Product[] Products { get; set; } = null;

        /// <summary>
        /// Results of the category lookup and search.
        /// </summary>
        public Dictionary<long, Category> Categories { get; set; } = null;

        /// <summary>
        /// Results of the category lookup and search with includeParents parameter.
        /// </summary>
        public Dictionary<long, Category> CategoryParents { get; set; } = null;

        /// <summary>
        /// Results of the deals request.
        /// </summary>
        public DealResponse Deals { get; set; } = null;

        /// <summary>
        /// Results of the best sellers request.
        /// </summary>
        public BestSellers BestSellersList { get; set; } = null;

        /// <summary>
        /// Results of the seller request.
        /// </summary>
        public Dictionary<string, Seller> Sellers { get; set; } = null;

        /// <summary>
        /// Results of get and add tracking operations.
        /// </summary>
        public Tracking[] Trackings { get; set; } = null;

        /// <summary>
        /// Results of get and add tracking operations.
        /// </summary>
        public Notification[] Notifications { get; set; } = null;

        /// <summary>
        /// A list of ASINs. Result of, but not limited to, the get tracking list operation.
        /// </summary>
        public string[] AsinList { get; set; } = null;

        /// <summary>
        /// Estimated count of all matched products.
        /// </summary>
        public int? TotalResults { get; set; } = null;

        /// <summary>
        /// A list of seller IDs.
        /// </summary>
        public string[] SellerIdList { get; set; } = null;

        /// <summary>
        /// A list of lightning deals.
        /// </summary>
        public LightningDeal[] LightningDeals { get; set; } = null;

        /// <summary>
        /// Contains information about any error that might have occurred.
        /// </summary>
        public RequestError Error { get; set; } = null;

        /// <summary>
        /// Contains request-specific additional output.
        /// </summary>
        public string Additional { get; set; } = null;

        /// <summary>
        /// If the request failed due to a C# exception (e.g. network error), this contains the exception object.
        /// </summary>
        [JsonIgnore] // Transient equivalent in C#
        public Exception Exception { get; set; } = null;

        /// <summary>
        /// Converts the response object into a JSON-formatted string.
        /// </summary>
        public override string ToString()
        {
            return Status == ResponseStatus.OK
                ? JsonConvert.SerializeObject(this, Formatting.None)
                : JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
