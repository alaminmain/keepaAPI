using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    public class Product
    {
        public string Asin { get; set; }
        public byte DomainId { get; set; }
        public string ParentAsin { get; set; }
        public string[] ParentAsinHistory { get; set; }
        public string VariationCSV { get; set; }
        public string[] UpcList { get; set; }
        public string[] EanList { get; set; }
        public string ImagesCSV { get; set; }
        public long[] Categories { get; set; }
        public long RootCategory { get; set; }
        public string Manufacturer { get; set; }
        public string Title { get; set; }
        public int TrackingSince { get; set; }
        public int ListedSince { get; set; }
        public string Brand { get; set; }
        public string ProductGroup { get; set; }
        public string PartNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Edition { get; set; }
        public string Format { get; set; }
        public string Author { get; set; }
        public string Binding { get; set; }
        public CategoryTreeEntry[] CategoryTree { get; set; }
        public int NumberOfItems { get; set; } = -1;
        public int NumberOfPages { get; set; } = -1;
        public int PublicationDate { get; set; } = -1;
        public int ReleaseDate { get; set; } = -1;
        public string[][] Languages { get; set; }
        public string[][] Contributors { get; set; }
        public string[] Features { get; set; }
        public string Description { get; set; }
        public int PackageHeight { get; set; } = -1;
        public int PackageLength { get; set; } = -1;
        public int PackageWidth { get; set; } = -1;
        public int PackageWeight { get; set; } = -1;
        public int PackageQuantity { get; set; } = -1;
        public int ItemHeight { get; set; } = -1;
        public int ItemLength { get; set; } = -1;
        public int ItemWidth { get; set; } = -1;
        public int ItemWeight { get; set; } = -1;
        public long[] EbayListingIds { get; set; }
        public bool IsAdultProduct { get; set; }
        public bool IsEligibleForTradeIn { get; set; }
        public int LastSoldUpdate { get; set; }
        public int MonthlySold { get; set; }
        public int[] MonthlySoldHistory { get; set; }
        public bool IsEligibleForSuperSaverShipping { get; set; }
        public int LastUpdate { get; set; }
        public int LastPriceChange { get; set; }
        public int LastEbayUpdate { get; set; }
        public int LastStockUpdate { get; set; }
        public int LastRatingUpdate { get; set; }
        public byte ProductType { get; set; }
        public bool HasReviews { get; set; }
        public Stats Stats { get; set; }
        public Offer[] Offers { get; set; }
        public int[] LiveOffersOrder { get; set; }
        public string[] BuyBoxSellerIdHistory { get; set; }
        public string[] BuyBoxUsedHistory { get; set; }
        public bool IsRedirectASIN { get; set; }
        public bool IsSNS { get; set; }
        public int[][] Csv { get; set; }
        public HashMap<long, int[]> SalesRanks { get; set; }
        public long SalesRankReference { get; set; } = -1;
        public long[] SalesRankReferenceHistory { get; set; }
        public bool OffersSuccessful { get; set; }
        public string[] FrequentlyBoughtTogether { get; set; }
        public bool IsMerchOnDemand { get; set; }
        public bool IsHeatSensitive { get; set; }
        public short? BusinessDiscount { get; set; }
        public int? LastBusinessDiscountUpdate { get; set; }
        public string SafetyWarning { get; set; }
        public string ProductBenefit { get; set; }
        public bool? BatteriesRequired { get; set; }
        public bool? BatteriesIncluded { get; set; }
        public string TargetAudienceKeyword { get; set; }
        public string Style { get; set; }
        public string IncludedComponents { get; set; }
        public string Material { get; set; }

        public enum ProductType
        {
            Standard = 0,
            Downloadable = 1,
            Ebook = 2,
            Unaccessible = 3,
            Invalid = 4,
            VariationParent = 5
        }

        public class CategoryTreeEntry
        {
            public long CatId { get; set; }
            public string Name { get; set; }
        }

        public class Stats
        {
            public int CurrentPrice { get; set; }
            public int Average30 { get; set; }
            public int Average90 { get; set; }
        }

        public class Offer
        {
            public int OfferId { get; set; }
            public int LastSeen { get; set; }
            public string SellerId { get; set; }
            public int[] OfferCSV { get; set; }
            public OfferCondition Condition { get; set; }
            public string ConditionComment { get; set; }
            public bool IsPrime { get; set; }
            public bool IsMAP { get; set; }
            public bool IsShippable { get; set; }
        }

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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
