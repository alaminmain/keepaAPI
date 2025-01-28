using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace keepaAPI.Structs
{
    public class Product
    {
        public string Asin { get; set; }
        public byte DomainId { get; set; }
        public string ParentAsin { get; set; }
        public string[] ParentAsinHistory { get; set; }
        public string VariationCSV { get; set; }
        public List<string> UpcList { get; set; }
        public List<string> EanList { get; set; }
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
        public int NumberOfItems { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationDate { get; set; }
        public int ReleaseDate { get; set; }
        public string[][] Languages { get; set; }
        public string[][] Contributors { get; set; }
        public string[] Features { get; set; }
        public string Description { get; set; }
        public int PackageHeight { get; set; }
        public int PackageLength { get; set; }
        public int PackageWidth { get; set; }
        public int PackageWeight { get; set; }
        public int PackageQuantity { get; set; }
        public int ItemHeight { get; set; }
        public int ItemLength { get; set; }
        public int ItemWidth { get; set; }
        public int ItemWeight { get; set; }
        public long[] EbayListingIds { get; set; }
        public bool IsAdultProduct { get; set; }
        public bool IsEligibleForTradeIn { get; set; }
        public int? ReferralFeePercent { get; set; }
        public int? VariableClosingFee { get; set; }
        public string UrlSlug { get; set; }
        public string Ingredients { get; set; }
        public bool? IsHaul { get; set; }
        public double? ReferralFeePercentage { get; set; }
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
        public string Type { get; set; }
        public bool HasReviews { get; set; }
        public Stats Stats { get; set; }
        public List<Offer> Offers { get; set; }
        public int[] LiveOffersOrder { get; set; }
        public string[] BuyBoxSellerIdHistory { get; set; }
        public string[] BuyBoxUsedHistory { get; set; }
        public bool IsRedirectASIN { get; set; }
        public bool IsSNS { get; set; }
        public int? SuggestedLowerPrice { get; set; }
        public int? CompetitivePriceThreshold { get; set; }
        public int[] BuyBoxEligibleOfferCounts { get; set; }
        public HazardousMaterial[] HazardousMaterials { get; set; }
        public bool OffersSuccessful { get; set; }
        public string[] FrequentlyBoughtTogether { get; set; }
        public bool? IsMerchOnDemand { get; set; }
        public bool? IsHeatSensitive { get; set; }
        public byte? ReturnRate { get; set; }
        public List<PromotionObject> Promotions { get; set; }
        public VariationObject[] Variations { get; set; }
        public int AvailabilityAmazon { get; set; }
        public int[] Coupon { get; set; }
        public bool NewPriceIsMAP { get; set; }
        public FBAFeesObject FbaFees { get; set; }
        public Dictionary<long, int[]> SalesRanks { get; set; }
        public long SalesRankReference { get; set; }
        public long[] SalesRankReferenceHistory { get; set; }
        public bool Launchpad { get; set; }
        public string RentalDetails { get; set; }
        public RentalObject RentalPrices { get; set; }
        public string RentalSellerId { get; set; }
        public int[] AvailabilityAmazonDelay { get; set; }
        public string AudienceRating { get; set; }
        public UnitCountObject UnitCount { get; set; }
        public int[][] Csv { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    //public class Stats
    //{
    //    public int[] Current { get; set; }
    //    public int[] Avg { get; set; }
    //    public int[] Avg30 { get; set; }
    //    public int[] Avg90 { get; set; }
    //    public int[] Avg180 { get; set; }
    //    public int[] Avg365 { get; set; }
    //    public int[] Min { get; set; }
    //    public int[] Max { get; set; }
    //}

    //public class Offer
    //{
    //    public string SellerId { get; set; }
    //    public int Price { get; set; }
    //    public int Shipping { get; set; }
    //    public bool IsFBA { get; set; }
    //}

    public class PromotionObject
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public int DiscountPercent { get; set; }
    }

    public class FBAFeesObject
    {
        public int StorageFee { get; set; }
        public int StorageFeeTax { get; set; }
        public int PickAndPackFee { get; set; }
        public int PickAndPackFeeTax { get; set; }
    }

    public class RentalObject
    {
        public int InitialPrice { get; set; }
        public int ShortExtnPrice { get; set; }
        public int LongExtnPrice { get; set; }
        public int FullPrice { get; set; }
    }

    public class UnitCountObject
    {
        public double UnitValue { get; set; }
        public string UnitType { get; set; }
        public double EachUnitCount { get; set; }
    }

    public class VariationObject
    {
        public string Asin { get; set; }
        public VariationAttributeObject[] Attributes { get; set; }
    }

    public class VariationAttributeObject
    {
        public string Dimension { get; set; }
        public string Value { get; set; }
    }

    public class CategoryTreeEntry
    {
        public long CatId { get; set; }
        public string Name { get; set; }
    }

    public class HazardousMaterial
    {
        public string Aspect { get; set; }
        public string Value { get; set; }
    }
}
