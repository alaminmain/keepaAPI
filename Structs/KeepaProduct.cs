using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static keepaAPI.Structs.Offer;

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
    public List<string> UpcList { get; set; }

    [JsonPropertyName("eanList")]
    public List<string> EanList { get; set; }

    [JsonPropertyName("imagesCSV")]
    public string ImagesCSV { get; set; }

    [JsonPropertyName("categories")]
    public long[] Categories { get; set; }

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

    [JsonPropertyName("languages")]
    public string[][] Languages { get; set; }

    [JsonPropertyName("contributors")]
    public string[][] Contributors { get; set; }

    [JsonPropertyName("features")]
    public string[] Features { get; set; }

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

    [JsonPropertyName("urlSlug")]
    public string UrlSlug { get; set; }

    [JsonPropertyName("ingredients")]
    public string Ingredients { get; set; }

    [JsonPropertyName("isHaul")]
    public bool? IsHaul { get; set; }

    [JsonPropertyName("monthlySold")]
    public int MonthlySold { get; set; }

    [JsonPropertyName("lastUpdate")]
    public int LastUpdate { get; set; }

    [JsonPropertyName("productType")]
    public byte ProductType { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("hasReviews")]
    public bool HasReviews { get; set; }

    [JsonPropertyName("stats")]
    public Stats Stats { get; set; }

    [JsonPropertyName("offers")]
    public List<Offer> Offers { get; set; }

    [JsonPropertyName("isRedirectASIN")]
    public bool IsRedirectASIN { get; set; }

    [JsonPropertyName("isSNS")]
    public bool IsSNS { get; set; }

    [JsonPropertyName("offersSuccessful")]
    public bool OffersSuccessful { get; set; }

    [JsonPropertyName("isMerchOnDemand")]
    public bool? IsMerchOnDemand { get; set; }

    [JsonPropertyName("isHeatSensitive")]
    public bool? IsHeatSensitive { get; set; }

    [JsonPropertyName("returnRate")]
    public byte? ReturnRate { get; set; }

    [JsonPropertyName("promotions")]
    public List<PromotionObject> Promotions { get; set; }

    [JsonPropertyName("variations")]
    public VariationObject[] Variations { get; set; }

    [JsonPropertyName("availabilityAmazon")]
    public int AvailabilityAmazon { get; set; }

    [JsonPropertyName("coupon")]
    public int[] Coupon { get; set; }

    [JsonPropertyName("launchpad")]
    public bool Launchpad { get; set; }

    [JsonPropertyName("rentalDetails")]
    public string RentalDetails { get; set; }

    [JsonPropertyName("audienceRating")]
    public string AudienceRating { get; set; }

    [JsonPropertyName("csv")]
    public int[][] Csv { get; set; }
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
    public int[] OfferCSV { get; set; }

    [JsonPropertyName("condition")]
    public OfferCondition Condition { get; set; }

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

    [JsonPropertyName("stockCSV")]
    public int[] StockCSV { get; set; }

    [JsonPropertyName("coupon")]
    public int Coupon { get; set; }

    [JsonPropertyName("couponHistory")]
    public int[] CouponHistory { get; set; }
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

public class FbaFees
{
    [Key]
    public int Id { get; set; }
    public int PickAndPackFee { get; set; }
}

public class HazardousMaterial
{
    [Key]
    public int Id { get; set; }
    [JsonPropertyName("aspect")]
    public string Aspect { get; set; }

    [JsonPropertyName("value")]
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

public class VariationObject
{
    [Key]
    public int Id { get; set; }
    [JsonPropertyName("asin")]
    public string Asin { get; set; }

    [JsonPropertyName("parentAsin")]
    public string ParentAsin { get; set; }

    [JsonPropertyName("variationCSV")]
    public string VariationCSV { get; set; }
}

public class PromotionObject
{
    [Key]
    public int Id { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("eligibilityRequirementDescription")]
    public string EligibilityRequirementDescription { get; set; }

    [JsonPropertyName("benefitDescription")]
    public string BenefitDescription { get; set; }

    [JsonPropertyName("promotionId")]
    public string PromotionId { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("discountPercent")]
    public int DiscountPercent { get; set; }
}

public class Stats
{
    [Key]
    public int Id { get; set; }
    [JsonPropertyName("current")]
    public int[] Current { get; set; }

    [JsonPropertyName("avg")]
    public int[] Avg { get; set; }

    [JsonPropertyName("avg30")]
    public int[] Avg30 { get; set; }

    [JsonPropertyName("avg90")]
    public int[] Avg90 { get; set; }

    [JsonPropertyName("avg180")]
    public int[] Avg180 { get; set; }

    [JsonPropertyName("avg365")]
    public int[] Avg365 { get; set; }

    [JsonPropertyName("atIntervalStart")]
    public int[] AtIntervalStart { get; set; }

    [JsonPropertyName("min")]
    public int[][] Min { get; set; }

    [JsonPropertyName("minInInterval")]
    public int[][] MinInInterval { get; set; }

    [JsonPropertyName("max")]
    public int[][] Max { get; set; }

    [JsonPropertyName("maxInInterval")]
    public int[][] MaxInInterval { get; set; }

    [JsonPropertyName("isLowest")]
    public bool[] IsLowest { get; set; }

    [JsonPropertyName("isLowest90")]
    public bool[] IsLowest90 { get; set; }

    [JsonPropertyName("isFBA")]
    public bool IsFBA { get; set; }
}
