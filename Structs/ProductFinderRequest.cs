using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Represents a product finder request used in the Keepa API.
    /// This class contains various filtering parameters for searching products.
    /// </summary>
    public class ProductFinderRequest
    {
        // General Filters
        public string[] Author { get; set; }
        public byte[] AvailabilityAmazon { get; set; }

        // Average Price Filters over different time periods (365, 180, 90, 30, 7, 1 days)
        public int? Avg365AmazonLte { get; set; }
        public int? Avg365AmazonGte { get; set; }
        public int? Avg180AmazonLte { get; set; }
        public int? Avg180AmazonGte { get; set; }
        public int? Avg90AmazonLte { get; set; }
        public int? Avg90AmazonGte { get; set; }
        public int? Avg30AmazonLte { get; set; }
        public int? Avg30AmazonGte { get; set; }
        public int? Avg7AmazonLte { get; set; }
        public int? Avg7AmazonGte { get; set; }
        public int? Avg1AmazonLte { get; set; }
        public int? Avg1AmazonGte { get; set; }

        // Buy Box & Used Shipping Filters
        public int? BuyBoxUsedConditionLte { get; set; }
        public int? BuyBoxUsedConditionGte { get; set; }
        public bool? BuyBoxUsedIsFba { get; set; }
        public string BuyBoxUsedSellerId { get; set; }

        // Category Filters
        public long[] CategoriesInclude { get; set; }
        public long[] CategoriesExclude { get; set; }

        // Product Attributes
        public string[] Color { get; set; }
        public string[] Binding { get; set; }
        public string[] Brand { get; set; }
        public string[] Size { get; set; }
        public string[] Edition { get; set; }
        public string[] Format { get; set; }
        public string[] Genre { get; set; }
        public string[] Manufacturer { get; set; }
        public string[] Model { get; set; }
        public string[] PartNumber { get; set; }
        public string[] ProductGroup { get; set; }
        public string[] Publisher { get; set; }
        public string[] SellerIds { get; set; }

        // Sales Rank Filters
        public int? SalesRankDrops30Lte { get; set; }
        public int? SalesRankDrops30Gte { get; set; }
        public int? SalesRankDrops90Lte { get; set; }
        public int? SalesRankDrops90Gte { get; set; }
        public int? SalesRankDrops180Lte { get; set; }
        public int? SalesRankDrops180Gte { get; set; }
        public int? SalesRankDrops365Lte { get; set; }
        public int? SalesRankDrops365Gte { get; set; }

        // Buy Box Stats
        public bool? BuyBoxIsAmazon { get; set; }
        public bool? BuyBoxIsFba { get; set; }
        public bool? BuyBoxIsUnqualified { get; set; }
        public string[] BuyBoxSellerId { get; set; }

        // Tracking and Listing Dates
        public int? TrackingSinceLte { get; set; }
        public int? TrackingSinceGte { get; set; }
        public int? ListedSinceLte { get; set; }
        public int? ListedSinceGte { get; set; }

        // Stock and Pricing Updates
        public int? LastOffersUpdateLte { get; set; }
        public int? LastOffersUpdateGte { get; set; }
        public int? LastPriceChangeLte { get; set; }
        public int? LastPriceChangeGte { get; set; }
        public int? LastRatingUpdateLte { get; set; }
        public int? LastRatingUpdateGte { get; set; }

        // Discounts and Coupons
        public int? CouponOneTimeAbsoluteLte { get; set; }
        public int? CouponOneTimeAbsoluteGte { get; set; }
        public int? CouponOneTimePercentLte { get; set; }
        public int? CouponOneTimePercentGte { get; set; }
        public int? CouponSNSPercentLte { get; set; }
        public int? CouponSNSPercentGte { get; set; }

        // Pagination
        public int PerPage { get; set; } = 50;
        public int Page { get; set; } = 0;

        /// <summary>
        /// Converts the request object into a JSON-formatted string.
        /// </summary>
        /// <returns>A JSON representation of the request.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}

