using System;
using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// Represents a marketplace offer.
    /// </summary>
    public class Offer
    {
        /// <summary>
        /// Unique ID of this offer in the scope of the product.
        /// </summary>
        public int OfferId { get; set; }

        /// <summary>
        /// The last time this offer was seen (updated) in Keepa Time minutes.
        /// </summary>
        public int LastSeen { get; set; } = 0;

        /// <summary>
        /// The seller ID of the merchant.
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// Contains the current price and shipping costs of the offer as well as history data.
        /// </summary>
        public int[] OfferCSV { get; set; }

        /// <summary>
        /// The condition of the offered product.
        /// </summary>
        public OfferCondition Condition { get; set; }

        /// <summary>
        /// The description of the condition.
        /// </summary>
        public string ConditionComment { get; set; }

        /// <summary>
        /// Whether or not this offer is available via Prime shipping (FBA).
        /// </summary>
        public bool IsPrime { get; set; }

        /// <summary>
        /// If the price of this offer is restricted by MAP (Minimum Advertised Price).
        /// </summary>
        public bool IsMAP { get; set; }

        /// <summary>
        /// Indicates if the offer is currently shippable.
        /// </summary>
        public bool IsShippable { get; set; }

        /// <summary>
        /// Indicates if the offer is an Add-on item.
        /// </summary>
        public bool IsAddonItem { get; set; }

        /// <summary>
        /// Indicates if the offer is a pre-order.
        /// </summary>
        public bool IsPreorder { get; set; }

        /// <summary>
        /// Indicates if the offer is a Warehouse Deal.
        /// </summary>
        public bool IsWarehouseDeal { get; set; }

        /// <summary>
        /// Indicates if the seller is a suspected scammer.
        /// </summary>
        public bool IsScam { get; set; }

        /// <summary>
        /// Indicates whether the offer ships from China.
        /// </summary>
        public bool ShipsFromChina { get; set; }

        /// <summary>
        /// True if the seller is Amazon (e.g., "Amazon.com").
        /// </summary>
        public bool IsAmazon { get; set; }

        /// <summary>
        /// Whether or not this offer is fulfilled by Amazon.
        /// </summary>
        public bool IsFBA { get; set; }

        /// <summary>
        /// Indicates if this offer has a discounted Prime-exclusive price.
        /// </summary>
        public bool IsPrimeExcl { get; set; }

        /// <summary>
        /// Prime exclusive price history.
        /// </summary>
        public int[] PrimeExclCSV { get; set; }

        /// <summary>
        /// Stock history of this offer.
        /// </summary>
        public int[] StockCSV { get; set; }

        /// <summary>
        /// Minimum order quantity.
        /// </summary>
        public int MinOrderQty { get; set; }

        /// <summary>
        /// One-time coupon details of this offer.
        /// Positive for absolute discount, negative for percentage discount.
        /// </summary>
        public int Coupon { get; set; }

        /// <summary>
        /// Coupon history for this offer.
        /// </summary>
        public int[] CouponHistory { get; set; }

        /// <summary>
        /// Returns the JSON representation of the object.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Represents the condition of the offered product.
        /// </summary>
        public enum OfferCondition
        {
            Unknown = 0,
            New = 1,
            UsedLikeNew = 2,
            UsedVeryGood = 3,
            UsedGood = 4,
            UsedAcceptable = 5,
            Refurbished = 6,
            CollectibleLikeNew = 7,
            CollectibleVeryGood = 8,
            CollectibleGood = 9,
            CollectibleAcceptable = 10
        }
    }
}
