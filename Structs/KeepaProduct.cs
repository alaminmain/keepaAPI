using System;
using System.Collections.Generic;

public class ProductResponse
{
    public long Timestamp { get; set; }
    public int TokensLeft { get; set; }
    public int RefillIn { get; set; }
    public int RefillRate { get; set; }
    public double TokenFlowReduction { get; set; }
    public int TokensConsumed { get; set; }
    public int ProcessingTimeInMs { get; set; }
    public List<Product> Products { get; set; }
}

public class Product
{
    public string Csv { get; set; }
    public List<int> Categories { get; set; }
    public string ImagesCSV { get; set; }
    public string Manufacturer { get; set; }
    public string Title { get; set; }
    public int LastUpdate { get; set; }
    public int LastPriceChange { get; set; }
    public int RootCategory { get; set; }
    public int ProductType { get; set; }
    public string ParentAsin { get; set; }
    public string VariationCSV { get; set; }
    public string Asin { get; set; }
    public int DomainId { get; set; }
    public string Type { get; set; }
    public bool HasReviews { get; set; }
    public int TrackingSince { get; set; }
    public string Brand { get; set; }
    public string ProductGroup { get; set; }
    public string PartNumber { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public string Edition { get; set; }
    public string Format { get; set; }
    public int PackageHeight { get; set; }
    public int PackageLength { get; set; }
    public int PackageWidth { get; set; }
    public int PackageWeight { get; set; }
    public int PackageQuantity { get; set; }
    public bool IsAdultProduct { get; set; }
    public bool IsEligibleForTradeIn { get; set; }
    public bool IsEligibleForSuperSaverShipping { get; set; }
    public List<Offer> Offers { get; set; }
    public object BuyBoxSellerIdHistory { get; set; }
    public bool IsRedirectASIN { get; set; }
    public bool IsSNS { get; set; }
    public string Author { get; set; }
    public string Binding { get; set; }
    public int NumberOfItems { get; set; }
    public int NumberOfPages { get; set; }
    public int PublicationDate { get; set; }
    public int ReleaseDate { get; set; }
    public List<List<string>> Languages { get; set; }
    public int LastRatingUpdate { get; set; }
    public object EbayListingIds { get; set; }
    public int LastEbayUpdate { get; set; }
    public List<string> EanList { get; set; }
    public List<string> UpcList { get; set; }
    public List<int> LiveOffersOrder { get; set; }
    public List<string> FrequentlyBoughtTogether { get; set; }
    public List<string> Features { get; set; }
    public string Description { get; set; }
    public List<Promotion> Promotions { get; set; }
    public bool NewPriceIsMAP { get; set; }
    public List<int> Coupon { get; set; }
    public int AvailabilityAmazon { get; set; }
    public int ListedSince { get; set; }
    public FbaFees FbaFees { get; set; }
    public object Variations { get; set; }
    public int ItemHeight { get; set; }
    public int ItemLength { get; set; }
    public int ItemWidth { get; set; }
    public int ItemWeight { get; set; }
    public int SalesRankReference { get; set; }
    public object SalesRanks { get; set; }
    public object SalesRankReferenceHistory { get; set; }
    public bool Launchpad { get; set; }
    public bool IsB2B { get; set; }
    public int LastSoldUpdate { get; set; }
    public int MonthlySold { get; set; }
    public List<int> BuyBoxEligibleOfferCounts { get; set; }
    public int CompetitivePriceThreshold { get; set; }
    public List<HazardousMaterial> HazardousMaterials { get; set; }
    public bool IsHeatSensitive { get; set; }
    public string UrlSlug { get; set; }
    public string Ingredients { get; set; }
    public UnitCount UnitCount { get; set; }
    public string ItemForm { get; set; }
    public string ItemTypeKeyword { get; set; }
    public string SafetyWarning { get; set; }
    public string TargetAudienceKeyword { get; set; }
    public string Style { get; set; }
    public string Scent { get; set; }
    public object Stats { get; set; }
    public bool OffersSuccessful { get; set; }
    public int G { get; set; }
    public List<CategoryTree> CategoryTree { get; set; }
    public int ReferralFeePercent { get; set; }
    public double ReferralFeePercentage { get; set; }
}

public class Offer
{
    public int LastSeen { get; set; }
    public string SellerId { get; set; }
    public List<int> OfferCSV { get; set; }
    public int Condition { get; set; }
    public string ConditionComment { get; set; }
    public bool IsPrime { get; set; }
    public bool IsMAP { get; set; }
    public bool IsShippable { get; set; }
    public bool IsAddonItem { get; set; }
    public bool IsPreorder { get; set; }
    public bool IsWarehouseDeal { get; set; }
    public bool IsScam { get; set; }
    public bool IsAmazon { get; set; }
    public bool IsPrimeExcl { get; set; }
    public int OfferId { get; set; }
    public bool IsFBA { get; set; }
    public bool ShipsFromChina { get; set; }
    public int MinOrderQty { get; set; }
    public List<int> CouponHistory { get; set; }
}

public class Promotion
{
    public string Type { get; set; }
    public string EligibilityRequirementDescription { get; set; }
    public string BenefitDescription { get; set; }
    public string PromotionId { get; set; }
    public int Amount { get; set; }
    public int DiscountPercent { get; set; }
}

public class FbaFees
{
    public int PickAndPackFee { get; set; }
}

public class HazardousMaterial
{
    public string Aspect { get; set; }
    public string Value { get; set; }
}

public class UnitCount
{
    public double UnitValue { get; set; }
    public string UnitType { get; set; }
}

public class CategoryTree
{
    public int CatId { get; set; }
    public string Name { get; set; }
}
