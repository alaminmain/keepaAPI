using keepaAPI.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static Azure.Core.HttpHeader;

public class ProductResponse
{
    [Key]
    public int Id { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("tokensLeft")]
    public int TokensLeft { get; set; }

    [JsonPropertyName("refillIn")]
    public int RefillIn { get; set; }

    [JsonPropertyName("refillRate")]
    public int RefillRate { get; set; }

    [JsonPropertyName("tokenFlowReduction")]
    public double TokenFlowReduction { get; set; }

    [JsonPropertyName("tokensConsumed")]
    public int TokensConsumed { get; set; }

    [JsonPropertyName("processingTimeInMs")]
    public int ProcessingTimeInMs { get; set; }

    [JsonPropertyName("products")]
    public List<Product> Products { get; set; }
}



public class Product
{
    [Key]
    public int Id { get; set; }

    [JsonPropertyName("asin")]
    public string Asin { get; set; }

    [JsonPropertyName("domainId")]
    public byte DomainId { get; set; }

    [JsonPropertyName("parentAsin")]
    public string ParentAsin { get; set; }

    [JsonPropertyName("variationCSV")]
    public string VariationCSV { get; set; }

    [JsonPropertyName("upcList")]
    public List<Upc> UpcList { get; set; }

    [JsonPropertyName("eanList")]
    public List<Ean> EanList { get; set; }

    [JsonPropertyName("imagesCSV")]
    public string ImagesCSV { get; set; }

    [JsonPropertyName("categories")]
    public List<long> Categories { get; set; }

    [JsonPropertyName("rootCategory")]
    public long RootCategory { get; set; }

    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("trackingSince")]
    public int TrackingSince { get; set; }

    [JsonPropertyName("listedSince")]
    public int ListedSince { get; set; }

    [JsonPropertyName("brand")]
    public string Brand { get; set; }

    [JsonPropertyName("productGroup")]
    public string ProductGroup { get; set; }

    [JsonPropertyName("partNumber")]
    public string PartNumber { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("size")]
    public string Size { get; set; }

    [JsonPropertyName("edition")]
    public string Edition { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("binding")]
    public string Binding { get; set; }

    [JsonPropertyName("numberOfItems")]
    public int NumberOfItems { get; set; }

    [JsonPropertyName("numberOfPages")]
    public int NumberOfPages { get; set; }

    [JsonPropertyName("publicationDate")]
    public int PublicationDate { get; set; }

    [JsonPropertyName("releaseDate")]
    public int ReleaseDate { get; set; }

    //[JsonPropertyName("languages")]
    //public List<Language> Languages { get; set; }

    //[JsonPropertyName("contributors")]
    //public List<Contributor> Contributors { get; set; }

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("packageHeight")]
    public int PackageHeight { get; set; }

    [JsonPropertyName("packageLength")]
    public int PackageLength { get; set; }

    [JsonPropertyName("packageWidth")]
    public int PackageWidth { get; set; }

    [JsonPropertyName("packageWeight")]
    public int PackageWeight { get; set; }

    [JsonPropertyName("packageQuantity")]
    public int PackageQuantity { get; set; }

    [JsonPropertyName("itemHeight")]
    public int ItemHeight { get; set; }

    [JsonPropertyName("itemLength")]
    public int ItemLength { get; set; }

    [JsonPropertyName("itemWidth")]
    public int ItemWidth { get; set; }

    [JsonPropertyName("itemWeight")]
    public int ItemWeight { get; set; }

    [JsonPropertyName("isAdultProduct")]
    public bool IsAdultProduct { get; set; }

    [JsonPropertyName("isEligibleForTradeIn")]
    public bool IsEligibleForTradeIn { get; set; }

    [JsonPropertyName("isEligibleForSuperSaverShipping")]
    public bool IsEligibleForSuperSaverShipping { get; set; }

    [JsonPropertyName("offers")]
    public List<Offer> Offers { get; set; }

    [JsonPropertyName("buyBoxSellerIdHistory")]
    public string BuyBoxSellerIdHistory { get; set; }

    [JsonPropertyName("isRedirectASIN")]
    public bool IsRedirectASIN { get; set; }

    [JsonPropertyName("isSNS")]
    public bool IsSNS { get; set; }

    //[JsonPropertyName("author")]
    //public string Author { get; set; }

    //[JsonPropertyName("binding")]
    //public string Binding { get; set; }

    //[JsonPropertyName("numberOfItems")]
    //public int NumberOfItems { get; set; }

    //[JsonPropertyName("numberOfPages")]
    //public int NumberOfPages { get; set; }

    //[JsonPropertyName("publicationDate")]
    //public int PublicationDate { get; set; }

    //[JsonPropertyName("releaseDate")]
    //public int ReleaseDate { get; set; }

    //[JsonPropertyName("languages")]
    //public List<Language> Languages { get; set; }

    [JsonPropertyName("lastRatingUpdate")]
    public int LastRatingUpdate { get; set; }

    [JsonPropertyName("ebayListingIds")]
    public string EbayListingIds { get; set; }

    [JsonPropertyName("lastEbayUpdate")]
    public int LastEbayUpdate { get; set; }

    //[JsonPropertyName("eanList")]
    //public List<Ean> EanList { get; set; }

    //[JsonPropertyName("upcList")]
    //public List<Upc> UpcList { get; set; }

    [JsonPropertyName("liveOffersOrder")]
    public List<int> LiveOffersOrder { get; set; }

    [JsonPropertyName("frequentlyBoughtTogether")]
    public List<FrequentlyBought> FrequentlyBoughtTogether { get; set; }

    //[JsonPropertyName("features")]
    //public List<Feature> Features { get; set; }

    //[JsonPropertyName("description")]
    //public string Description { get; set; }

    [JsonPropertyName("promotions")]
    public List<Promotion> Promotions { get; set; }

    [JsonPropertyName("newPriceIsMAP")]
    public bool NewPriceIsMAP { get; set; }

    [JsonPropertyName("coupon")]
    public List<int> Coupon { get; set; }

    [JsonPropertyName("availabilityAmazon")]
    public int AvailabilityAmazon { get; set; }

    //[JsonPropertyName("listedSince")]
    //public int ListedSince { get; set; }

    //[JsonPropertyName("fbaFees")]
    //public FbaFees FbaFees { get; set; }

    [JsonPropertyName("variations")]
    public List<Variation> Variations { get; set; }

   

    [JsonPropertyName("salesRankReference")]
    public int SalesRankReference { get; set; }

    [JsonPropertyName("salesRanks")]
    public List<SalesRank> SalesRanks { get; set; }

    [JsonPropertyName("salesRankReferenceHistory")]
    public List<SalesRankReferenceHistory> SalesRankReferenceHistory { get; set; }

    [JsonPropertyName("launchpad")]
    public bool Launchpad { get; set; }

    [JsonPropertyName("isB2B")]
    public bool IsB2B { get; set; }

    [JsonPropertyName("lastSoldUpdate")]
    public int LastSoldUpdate { get; set; }

    [JsonPropertyName("monthlySold")]
    public int MonthlySold { get; set; }

    [JsonPropertyName("buyBoxEligibleOfferCounts")]
    public List<int> BuyBoxEligibleOfferCounts { get; set; }

    [JsonPropertyName("competitivePriceThreshold")]
    public int CompetitivePriceThreshold { get; set; }

    [JsonPropertyName("hazardousMaterials")]
    public List<HazardousMaterial> HazardousMaterials { get; set; }

    [JsonPropertyName("isHeatSensitive")]
    public bool IsHeatSensitive { get; set; }

    [JsonPropertyName("urlSlug")]
    public string UrlSlug { get; set; }

    [JsonPropertyName("ingredients")]
    public string Ingredients { get; set; }

    [JsonPropertyName("unitCount")]
    public UnitCount UnitCount { get; set; }

    [JsonPropertyName("itemForm")]
    public string ItemForm { get; set; }

    [JsonPropertyName("itemTypeKeyword")]
    public string ItemTypeKeyword { get; set; }

    [JsonPropertyName("safetyWarning")]
    public string SafetyWarning { get; set; }

    [JsonPropertyName("targetAudienceKeyword")]
    public string TargetAudienceKeyword { get; set; }

    [JsonPropertyName("style")]
    public string Style { get; set; }

    [JsonPropertyName("scent")]
    public string Scent { get; set; }

    //[JsonPropertyName("stats")]
    //public Stats Stats { get; set; }

    [JsonPropertyName("offersSuccessful")]
    public bool OffersSuccessful { get; set; }

    [JsonPropertyName("g")]
    public int G { get; set; }

    [JsonPropertyName("categoryTree")]
    public List<CategoryTree> CategoryTree { get; set; }

    [JsonPropertyName("referralFeePercent")]
    public int ReferralFeePercent { get; set; }

    [JsonPropertyName("referralFeePercentage")]
    public double ReferralFeePercentage { get; set; }
}





public class Offer
{
    [Key]
    public int Id { get; set; }

    [JsonPropertyName("lastSeen")]
    public int LastSeen { get; set; }

    [JsonPropertyName("offerId")]
    public int OfferId { get; set; }

    [JsonPropertyName("sellerId")]
    public string SellerId { get; set; }

    [JsonPropertyName("offerCSV")]
    public List<int> OfferCSV { get; set; }

    [JsonPropertyName("condition")]
    public int Condition { get; set; }

    [JsonPropertyName("conditionComment")]
    public string ConditionComment { get; set; }

    [JsonPropertyName("isPrime")]
    public bool IsPrime { get; set; }

    [JsonPropertyName("isMAP")]
    public bool IsMAP { get; set; }

    [JsonPropertyName("isShippable")]
    public bool IsShippable { get; set; }

    [JsonPropertyName("isAddonItem")]
    public bool IsAddonItem { get; set; }

    [JsonPropertyName("isPreorder")]
    public bool IsPreorder { get; set; }

    [JsonPropertyName("isWarehouseDeal")]
    public bool IsWarehouseDeal { get; set; }

    [JsonPropertyName("isScam")]
    public bool IsScam { get; set; }

    [JsonPropertyName("shipsFromChina")]
    public bool ShipsFromChina { get; set; }

    [JsonPropertyName("isAmazon")]
    public bool IsAmazon { get; set; }

    [JsonPropertyName("isFBA")]
    public bool IsFBA { get; set; }

    [JsonPropertyName("isPrimeExcl")]
    public bool IsPrimeExcl { get; set; }

    //[JsonPropertyName("stockCSV")]
    //public List<StockCsv> StockCSV { get; set; }

    //[JsonPropertyName("coupon")]
    //public int Coupon { get; set; }

    //[JsonPropertyName("couponHistory")]
    //public List<CouponHistory> CouponHistory { get; set; }
}
public class Upc
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}

public class Ean
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}

public class Category
{
    [Key]
    public int Id { get; set; }
    public long Value { get; set; }
}

public class Language
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}

public class Contributor
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}

public class Feature
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}

public class Csv
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class OfferCsv
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class StockCsv
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class CouponHistory
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class Promotion
{
    [Key]
    public int Id { get; set; }
    public string Type { get; set; }
    public string EligibilityRequirementDescription { get; set; }
    public string BenefitDescription { get; set; }
    public string PromotionId { get; set; }
    public int Amount { get; set; }
    public int DiscountPercent { get; set; }
}

public class Variation
{
    [Key]
    public int Id { get; set; }
    public string Asin { get; set; }
    public string ParentAsin { get; set; }
    public string VariationCSV { get; set; }
}

public class FbaFees
{
    [Key]
    public int Id { get; set; }
    public int PickAndPackFee { get; set; }
}

public class SalesRank
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class SalesRankReferenceHistory
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class BuyBoxEligibleOfferCount
{
    [Key]
    public int Id { get; set; }
    public int Value { get; set; }
}

public class HazardousMaterial
{
    [Key]
    public int Id { get; set; }
    public string Aspect { get; set; }
    public string Value { get; set; }
}

public class UnitCount
{
    [Key]
    public int Id { get; set; }
    public double UnitValue { get; set; }
    public string UnitType { get; set; }
}

public class CategoryTree
{
    [Key]
    public int Id { get; set; }
    public int CatId { get; set; }
    public string Name { get; set; }
}

public class FrequentlyBought
{
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
}