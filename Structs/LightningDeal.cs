using System;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Represents a Lightning Deal on Amazon.
    /// </summary>
    public class LightningDeal
    {
        /// <summary>
        /// The domainId of the product's Amazon locale.
        /// </summary>
        public byte DomainId { get; set; }

        /// <summary>
        /// The last update time of the Lightning Deal in Keepa Time minutes.
        /// </summary>
        public int LastUpdate { get; set; }

        /// <summary>
        /// The ASIN of the product.
        /// </summary>
        public string Asin { get; set; }

        /// <summary>
        /// Title of the product. May contain HTML markup in rare cases.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The seller name offering this deal.
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// The seller ID offering this deal.
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// A unique ID for this deal.
        /// </summary>
        public string DealId { get; set; }

        /// <summary>
        /// The discounted price of this deal. -1 if the deal’s state is upcoming.
        /// </summary>
        public int DealPrice { get; set; }

        /// <summary>
        /// The regular price of this product. -1 if the deal’s state is upcoming.
        /// </summary>
        public int CurrentPrice { get; set; }

        /// <summary>
        /// The URL or name of the primary product image.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Whether or not the deal is Prime eligible.
        /// </summary>
        public bool IsPrimeEligible { get; set; }

        /// <summary>
        /// Whether or not the deal is fulfilled by Amazon.
        /// </summary>
        public bool IsFulfilledByAmazon { get; set; }

        /// <summary>
        /// Whether or not the price is restricted by MAP (Minimum Advertised Price).
        /// </summary>
        public bool IsMAP { get; set; }

        /// <summary>
        /// The rating of the product. A rating is an integer from 0 to 50 (e.g., 45 = 4.5 stars).
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// The total number of reviews for the product.
        /// </summary>
        public int TotalReviews { get; set; }

        /// <summary>
        /// The state of the deal.
        /// </summary>
        public DealState State { get; set; }

        /// <summary>
        /// The start time of this Lightning Deal in Keepa Time minutes.
        /// </summary>
        public int StartTime { get; set; }

        /// <summary>
        /// The end time of this Lightning Deal in Keepa Time minutes.
        /// </summary>
        public int EndTime { get; set; }

        /// <summary>
        /// The percentage of the Lightning Deal that has been claimed.
        /// </summary>
        public int PercentClaimed { get; set; }

        /// <summary>
        /// The provided discount percentage of this deal, according to Amazon.
        /// </summary>
        public int PercentOff { get; set; }

        /// <summary>
        /// The dimension attributes of this deal.
        /// </summary>
        public VariationAttributeObject[] Variation { get; set; }

        /// <summary>
        /// Represents the possible states of a Lightning Deal.
        /// </summary>
        public enum DealState
        {
            Available,
            Upcoming,
            Waitlist,
            SoldOut,
            WaitlistFull,
            Expired,
            Suppressed
        }
    }
}
