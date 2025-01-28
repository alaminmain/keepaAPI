using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace keepaAPI.Structs
{
    /// <summary>
    /// The Seller class provides information about an Amazon marketplace seller.
    /// </summary>
    public class Seller
    {
        /// <summary>
        /// States the time we have started tracking this seller, in Keepa Time minutes.
        /// </summary>
        public int TrackedSince { get; set; }

        /// <summary>
        /// The domainId of the products Amazon locale.
        /// </summary>
        public byte DomainId { get; set; }

        /// <summary>
        /// The seller id of the merchant.
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// The name of the seller.
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// Two-dimensional history array containing history data for this seller.
        /// </summary>
        public int[][] Csv { get; set; }

        /// <summary>
        /// States the time of our last update of this seller, in Keepa Time minutes.
        /// </summary>
        public int LastUpdate { get; set; }

        /// <summary>
        /// Indicates whether or not our system identified that this seller attempts to scam users.
        /// </summary>
        public bool IsScammer { get; set; }

        /// <summary>
        /// Indicates whether or not this seller ships from China.
        /// </summary>
        public bool ShipsFromChina { get; set; }

        /// <summary>
        /// Boolean value indicating whether or not the seller currently has FBA listings.
        /// </summary>
        public bool HasFBA { get; set; }

        /// <summary>
        /// Contains the number of storefront ASINs if available and the last update of that metric.
        /// </summary>
        public int[] TotalStorefrontAsins { get; set; }

        /// <summary>
        /// String array containing up to 100,000 storefront ASINs, sorted by freshest first.
        /// </summary>
        public string[] AsinList { get; set; }

        /// <summary>
        /// Contains the last time we were able to verify each ASIN in the AsinList field.
        /// </summary>
        public int[] AsinListLastSeen { get; set; }

        /// <summary>
        /// Contains the total amount of listings of this seller, including historical data.
        /// </summary>
        public int[] TotalStorefrontAsinsCSV { get; set; }

        /// <summary>
        /// Statistics about the primary categories of this seller.
        /// </summary>
        public MerchantCategoryStatistics[] SellerCategoryStatistics { get; set; }

        /// <summary>
        /// Statistics about the primary brands of this seller.
        /// </summary>
        public MerchantBrandStatistics[] SellerBrandStatistics { get; set; }

        /// <summary>
        /// The business address of the seller.
        /// </summary>
        public string[] Address { get; set; }

        /// <summary>
        /// Contains up to 5 of the most recent customer feedbacks.
        /// </summary>
        public FeedbackObject[] RecentFeedback { get; set; }

        /// <summary>
        /// States the time of our last rating data update of this seller.
        /// </summary>
        public int LastRatingUpdate { get; set; }

        /// <summary>
        /// Contains the neutral percentage ratings for the last 30 days, 90 days, 365 days, and lifetime.
        /// </summary>
        public int[] NeutralRating { get; set; }

        /// <summary>
        /// Contains the negative percentage ratings for the last 30 days, 90 days, 365 days, and lifetime.
        /// </summary>
        public int[] NegativeRating { get; set; }

        /// <summary>
        /// Contains the positive percentage ratings for the last 30 days, 90 days, 365 days, and lifetime.
        /// </summary>
        public int[] PositiveRating { get; set; }

        /// <summary>
        /// Contains the rating counts for the last 30 days, 90 days, 365 days, and lifetime.
        /// </summary>
        public int[] RatingCount { get; set; }

        /// <summary>
        /// The customer service address.
        /// </summary>
        public string[] CustomerServicesAddress { get; set; }

        /// <summary>
        /// The Trade Register Number.
        /// </summary>
        public string TradeNumber { get; set; }

        /// <summary>
        /// The business name.
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// The VAT number.
        /// </summary>
        public string VatID { get; set; }

        /// <summary>
        /// The phone number of the business.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The business type.
        /// </summary>
        public string BusinessType { get; set; }

        /// <summary>
        /// The share capital.
        /// </summary>
        public string ShareCapital { get; set; }

        /// <summary>
        /// The name of the business representative.
        /// </summary>
        public string Representative { get; set; }

        /// <summary>
        /// The email address of the business.
        /// </summary>
        public string Email { get; set; }

        public int CurrentRating { get; set; }
        public int CurrentRatingCount { get; set; }
        public int RatingsLast30Days { get; set; }

        /// <summary>
        /// Converts the object to a JSON string.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Enum representing CSV types.
        /// </summary>
        public enum MerchantCsvType
        {
            RATING = 0,
            RATING_COUNT = 1
        }

        /// <summary>
        /// Represents statistics about a seller's brand.
        /// </summary>
        public class MerchantBrandStatistics
        {
            /// <summary>
            /// The brand name (in lowercase).
            /// </summary>
            public string Brand { get; set; }

            /// <summary>
            /// The number of products this merchant sells with this brand.
            /// </summary>
            public int ProductCount { get; set; }

            /// <summary>
            /// The 30-day average sales rank of these products.
            /// </summary>
            public int Avg30SalesRank { get; set; }

            /// <summary>
            /// The number of products that have an Amazon offer.
            /// </summary>
            public int ProductCountWithAmazonOffer { get; set; }
        }

        /// <summary>
        /// Represents statistics about a seller's category.
        /// </summary>
        public class MerchantCategoryStatistics
        {
            /// <summary>
            /// The category ID.
            /// </summary>
            public long CatId { get; set; }

            /// <summary>
            /// The number of products this merchant sells with this category.
            /// </summary>
            public int ProductCount { get; set; }

            /// <summary>
            /// The 30-day average sales rank of these products.
            /// </summary>
            public int Avg30SalesRank { get; set; }

            /// <summary>
            /// The number of products that have an Amazon offer.
            /// </summary>
            public int ProductCountWithAmazonOffer { get; set; }
        }

        /// <summary>
        /// Represents a customer feedback entry.
        /// </summary>
        public class FeedbackObject
        {
            /// <summary>
            /// The feedback star rating (range: 10-50, where 10 = 1 star and 50 = 5 stars).
            /// </summary>
            public int Rating { get; set; }

            /// <summary>
            /// Timestamp of the feedback, in Keepa Time minutes.
            /// </summary>
            public int Date { get; set; }

            /// <summary>
            /// The feedback text.
            /// </summary>
            public string Feedback { get; set; }

            /// <summary>
            /// Whether or not the feedback is striked.
            /// </summary>
            public bool IsStriked { get; set; }
        }
    }
}
