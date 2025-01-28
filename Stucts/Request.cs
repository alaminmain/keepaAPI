using System;
using System.Collections.Generic;
using keepaAPI.Stucts;
using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// Represents a general API request with parameters.
    /// </summary>
    public class Request
    {
        public Dictionary<string, string> Parameter { get; set; }
        public string PostData { get; set; }
        public string Path { get; set; }

        public Request()
        {
            Parameter = new Dictionary<string, string>();
        }

        /// <summary>
        /// Converts the request object into a JSON-formatted string.
        /// </summary>
        /// <returns>A JSON representation of the request.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Creates a request for retrieving deals.
        /// </summary>
        public static Request GetDealsRequest(DealRequest dealRequest)
        {
            return new Request
            {
                Path = "deal",
                PostData = JsonConvert.SerializeObject(dealRequest)
            };
        }

        /// <summary>
        /// Creates a request for retrieving lightning deals.
        /// </summary>
        public static Request GetLightningDealRequest(AmazonLocale domainId, string asin = null)
        {
            var request = new Request
            {
                Path = "lightningdeal"
            };
            request.Parameter["domain"] = ((int)domainId).ToString();

            if (!string.IsNullOrEmpty(asin))
                request.Parameter["asin"] = asin;

            return request;
        }

        /// <summary>
        /// Creates a product finder request.
        /// </summary>
        public static Request GetProductFinderRequest(AmazonLocale domainId, ProductFinderRequest finderRequest)
        {
            var request = new Request
            {
                Path = "query"
            };
            request.Parameter["domain"] = ((int)domainId).ToString();
            request.Parameter["selection"] = JsonConvert.SerializeObject(finderRequest);
            return request;
        }

        /// <summary>
        /// Creates a request to add a single tracking.
        /// </summary>
        public static Request GetTrackingAddRequest(TrackingRequest trackingRequest)
        {
            return GetTrackingBatchAddRequest(trackingRequest);
        }

        /// <summary>
        /// Creates a request to batch-add multiple trackings.
        /// </summary>
        public static Request GetTrackingBatchAddRequest(params TrackingRequest[] trackingRequests)
        {
            if (trackingRequests.Length > 1000) return null;

            return new Request
            {
                Path = "tracking",
                PostData = JsonConvert.SerializeObject(trackingRequests)
            };
        }

        /// <summary>
        /// Creates a request to get tracking information by ASIN.
        /// </summary>
        public static Request GetTrackingGetRequest(string asin)
        {
            return new Request
            {
                Path = "tracking",
                Parameter = { ["type"] = "get", ["asin"] = asin }
            };
        }

        /// <summary>
        /// Creates a request to get all tracking items.
        /// </summary>
        public static Request GetTrackingListRequest(bool asinsOnly)
        {
            return new Request
            {
                Path = "tracking",
                Parameter = { ["type"] = "list", ["asins-only"] = asinsOnly ? "1" : "0" }
            };
        }

        /// <summary>
        /// Creates a request to get recent tracking notifications.
        /// </summary>
        public static Request GetTrackingNotificationRequest(int since, bool revise)
        {
            return new Request
            {
                Path = "tracking",
                Parameter =
                {
                    ["since"] = since.ToString(),
                    ["revise"] = revise ? "1" : "0",
                    ["type"] = "notification"
                }
            };
        }

        /// <summary>
        /// Creates a request to remove tracking for an ASIN.
        /// </summary>
        public static Request GetTrackingRemoveRequest(string asin)
        {
            return new Request
            {
                Path = "tracking",
                Parameter = { ["type"] = "remove", ["asin"] = asin }
            };
        }

        /// <summary>
        /// Creates a request to remove all tracking entries.
        /// </summary>
        public static Request GetTrackingRemoveAllRequest()
        {
            return new Request
            {
                Path = "tracking",
                Parameter = { ["type"] = "removeAll" }
            };
        }

        /// <summary>
        /// Creates a request to update the tracking webhook URL.
        /// </summary>
        public static Request GetTrackingWebhookRequest(string url)
        {
            return new Request
            {
                Path = "tracking",
                Parameter = { ["type"] = "webhook", ["url"] = url }
            };
        }

        /// <summary>
        /// Retrieves a list of best-selling products in a category.
        /// </summary>
        public static Request GetBestSellersRequest(AmazonLocale domainId, long category)
        {
            return new Request
            {
                Path = "bestsellers",
                Parameter =
                {
                    ["category"] = category.ToString(),
                    ["domain"] = ((int)domainId).ToString()
                }
            };
        }

        /// <summary>
        /// Retrieves category details by ID.
        /// </summary>
        public static Request GetCategoryLookupRequest(AmazonLocale domainId, long category, bool includeParents)
        {
            var request = new Request
            {
                Path = "category",
                Parameter =
                {
                    ["category"] = category.ToString(),
                    ["domain"] = ((int)domainId).ToString()
                }
            };

            if (includeParents)
                request.Parameter["parents"] = "1";

            return request;
        }

        /// <summary>
        /// Searches for Amazon categories by name.
        /// </summary>
        public static Request GetCategorySearchRequest(AmazonLocale domainId, string term, bool includeParents)
        {
            var request = new Request
            {
                Path = "search",
                Parameter =
                {
                    ["domain"] = ((int)domainId).ToString(),
                    ["type"] = "category",
                    ["term"] = term
                }
            };

            if (includeParents)
                request.Parameter["parents"] = "1";

            return request;
        }

        /// <summary>
        /// Retrieves seller details by seller ID.
        /// </summary>
        public static Request GetSellerRequest(AmazonLocale domainId, params string[] sellers)
        {
            return new Request
            {
                Path = "seller",
                Parameter =
                {
                    ["domain"] = ((int)domainId).ToString(),
                    ["seller"] = string.Join(",", sellers)
                }
            };
        }

        /// <summary>
        /// Retrieves a list of the most rated Amazon marketplace sellers.
        /// </summary>
        public static Request GetTopSellerRequest(AmazonLocale domainId)
        {
            return new Request
            {
                Path = "topseller",
                Parameter = { ["domain"] = ((int)domainId).ToString() }
            };
        }

        /// <summary>
        /// Searches for Amazon products using keywords.
        /// </summary>
        public static Request GetProductSearchRequest(AmazonLocale domainId, string term, int? stats = null, int? page = null)
        {
            var request = new Request
            {
                Path = "search",
                Parameter =
                {
                    ["domain"] = ((int)domainId).ToString(),
                    ["type"] = "product",
                    ["term"] = term
                }
            };

            if (stats.HasValue)
                request.Parameter["stats"] = stats.Value.ToString();
            if (page.HasValue)
                request.Parameter["page"] = page.Value.ToString();

            return request;
        }

        /// <summary>
        /// Retrieves a product object for the given ASIN.
        /// </summary>
        public static Request GetProductRequest(AmazonLocale domainId, int? stats, int? offers, params string[] asins)
        {
            var request = new Request
            {
                Path = "product",
                Parameter =
                {
                    ["asin"] = string.Join(",", asins),
                    ["domain"] = ((int)domainId).ToString()
                }
            };

            if (stats.HasValue)
                request.Parameter["stats"] = stats.Value.ToString();
            if (offers.HasValue)
                request.Parameter["offers"] = offers.Value.ToString();

            return request;
        }
    }
}
