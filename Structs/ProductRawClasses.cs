// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
namespace keepaAPI.Structs.ProductRawClasses;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Attribute
{
    [JsonProperty("dimension", NullValueHandling = NullValueHandling.Ignore)]
    public string Dimension { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}

public class CategoryTree
{
    [JsonProperty("catId", NullValueHandling = NullValueHandling.Ignore)]
    public int? CatId { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }
}

public class FbaFees
{
    [JsonProperty("pickAndPackFee", NullValueHandling = NullValueHandling.Ignore)]
    public int? PickAndPackFee { get; set; }
}

public class HazardousMaterial
{
    [JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
    public string Aspect { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public string Value { get; set; }
}

public class Offer
{
    [JsonProperty("lastSeen", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastSeen { get; set; }

    [JsonProperty("sellerId", NullValueHandling = NullValueHandling.Ignore)]
    public string SellerId { get; set; }

    [JsonProperty("offerCSV", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> OfferCSV { get; set; }

    [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
    public int? Condition { get; set; }

    [JsonProperty("conditionComment", NullValueHandling = NullValueHandling.Ignore)]
    public object ConditionComment { get; set; }

    [JsonProperty("isPrime", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrime { get; set; }

    [JsonProperty("isMAP", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMAP { get; set; }

    [JsonProperty("isShippable", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsShippable { get; set; }

    [JsonProperty("isAddonItem", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAddonItem { get; set; }

    [JsonProperty("isPreorder", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPreorder { get; set; }

    [JsonProperty("isWarehouseDeal", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsWarehouseDeal { get; set; }

    [JsonProperty("isScam", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsScam { get; set; }

    [JsonProperty("isAmazon", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAmazon { get; set; }

    [JsonProperty("isPrimeExcl", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPrimeExcl { get; set; }

    [JsonProperty("offerId", NullValueHandling = NullValueHandling.Ignore)]
    public int? OfferId { get; set; }

    [JsonProperty("isFBA", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsFBA { get; set; }

    [JsonProperty("shipsFromChina", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShipsFromChina { get; set; }

    [JsonProperty("minOrderQty", NullValueHandling = NullValueHandling.Ignore)]
    public int? MinOrderQty { get; set; }

    [JsonProperty("couponHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> CouponHistory { get; set; }
}

public class Product
{
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("csv", NullValueHandling = NullValueHandling.Ignore)]
    public List<List<int?>> Csv { get; set; }

    [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
    public List<object> Categories { get; set; }

    [JsonProperty("imagesCSV", NullValueHandling = NullValueHandling.Ignore)]
    public string ImagesCSV { get; set; }

    [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
    public string Manufacturer { get; set; }

    [JsonProperty("lastUpdate", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastUpdate { get; set; }

    [JsonProperty("lastPriceChange", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastPriceChange { get; set; }

    [JsonProperty("rootCategory", NullValueHandling = NullValueHandling.Ignore)]
    public int? RootCategory { get; set; }

    [JsonProperty("productType", NullValueHandling = NullValueHandling.Ignore)]
    public int? ProductType { get; set; }

    [JsonProperty("parentAsin", NullValueHandling = NullValueHandling.Ignore)]
    public string ParentAsin { get; set; }

    [JsonProperty("variationCSV", NullValueHandling = NullValueHandling.Ignore)]
    public string VariationCSV { get; set; }

    [JsonProperty("asin", NullValueHandling = NullValueHandling.Ignore)]
    public string Asin { get; set; }

    [JsonProperty("domainId", NullValueHandling = NullValueHandling.Ignore)]
    public int? DomainId { get; set; }

    [JsonProperty("hasReviews", NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasReviews { get; set; }

    [JsonProperty("trackingSince", NullValueHandling = NullValueHandling.Ignore)]
    public int? TrackingSince { get; set; }

    [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
    public string Brand { get; set; }

    [JsonProperty("productGroup", NullValueHandling = NullValueHandling.Ignore)]
    public string ProductGroup { get; set; }

    [JsonProperty("partNumber", NullValueHandling = NullValueHandling.Ignore)]
    public string PartNumber { get; set; }

    [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
    public string Model { get; set; }

    [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
    public string Color { get; set; }

    [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
    public string Size { get; set; }

    [JsonProperty("edition", NullValueHandling = NullValueHandling.Ignore)]
    public object Edition { get; set; }

    [JsonProperty("packageHeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? PackageHeight { get; set; }

    [JsonProperty("packageLength", NullValueHandling = NullValueHandling.Ignore)]
    public int? PackageLength { get; set; }

    [JsonProperty("packageWidth", NullValueHandling = NullValueHandling.Ignore)]
    public int? PackageWidth { get; set; }

    [JsonProperty("packageWeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? PackageWeight { get; set; }

    [JsonProperty("packageQuantity", NullValueHandling = NullValueHandling.Ignore)]
    public int? PackageQuantity { get; set; }

    [JsonProperty("isAdultProduct", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAdultProduct { get; set; }

    [JsonProperty("isEligibleForTradeIn", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEligibleForTradeIn { get; set; }

    [JsonProperty("isEligibleForSuperSaverShipping", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEligibleForSuperSaverShipping { get; set; }

    [JsonProperty("offers", NullValueHandling = NullValueHandling.Ignore)]
    public List<Offer> Offers { get; set; }

    [JsonProperty("buyBoxSellerIdHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> BuyBoxSellerIdHistory { get; set; }

    [JsonProperty("isRedirectASIN", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRedirectASIN { get; set; }

    [JsonProperty("isSNS", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSNS { get; set; }

    [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
    public string Author { get; set; }

    [JsonProperty("binding", NullValueHandling = NullValueHandling.Ignore)]
    public string Binding { get; set; }

    [JsonProperty("numberOfItems", NullValueHandling = NullValueHandling.Ignore)]
    public int? NumberOfItems { get; set; }

    [JsonProperty("numberOfPages", NullValueHandling = NullValueHandling.Ignore)]
    public int? NumberOfPages { get; set; }

    [JsonProperty("publicationDate", NullValueHandling = NullValueHandling.Ignore)]
    public int? PublicationDate { get; set; }

    [JsonProperty("releaseDate", NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseDate { get; set; }

    [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
    public List<List<string>> Languages { get; set; }

    [JsonProperty("lastRatingUpdate", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastRatingUpdate { get; set; }

    [JsonProperty("ebayListingIds", NullValueHandling = NullValueHandling.Ignore)]
    public List<long?> EbayListingIds { get; set; }

    [JsonProperty("lastEbayUpdate", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastEbayUpdate { get; set; }

    [JsonProperty("eanList", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> EanList { get; set; }

    [JsonProperty("upcList", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> UpcList { get; set; }

    [JsonProperty("liveOffersOrder", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> LiveOffersOrder { get; set; }

    [JsonProperty("frequentlyBoughtTogether", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> FrequentlyBoughtTogether { get; set; }

    [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Features { get; set; }

    [JsonProperty("promotions", NullValueHandling = NullValueHandling.Ignore)]
    public List<Promotion> Promotions { get; set; }

    [JsonProperty("newPriceIsMAP", NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewPriceIsMAP { get; set; }

    [JsonProperty("coupon", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> Coupon { get; set; }

    [JsonProperty("availabilityAmazon", NullValueHandling = NullValueHandling.Ignore)]
    public int? AvailabilityAmazon { get; set; }

    [JsonProperty("listedSince", NullValueHandling = NullValueHandling.Ignore)]
    public int? ListedSince { get; set; }

    [JsonProperty("fbaFees", NullValueHandling = NullValueHandling.Ignore)]
    public FbaFees FbaFees { get; set; }

    [JsonProperty("variations", NullValueHandling = NullValueHandling.Ignore)]
    public List<Variation> Variations { get; set; }

    [JsonProperty("itemHeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemHeight { get; set; }

    [JsonProperty("itemLength", NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemLength { get; set; }

    [JsonProperty("itemWidth", NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemWidth { get; set; }

    [JsonProperty("itemWeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemWeight { get; set; }

    [JsonProperty("salesRankReference", NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesRankReference { get; set; }

    [JsonProperty("salesRanks", NullValueHandling = NullValueHandling.Ignore)]
    public SalesRanks SalesRanks { get; set; }

    [JsonProperty("salesRankReferenceHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> SalesRankReferenceHistory { get; set; }

    [JsonProperty("launchpad", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Launchpad { get; set; }

    [JsonProperty("isB2B", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsB2B { get; set; }

    [JsonProperty("contributors", NullValueHandling = NullValueHandling.Ignore)]
    public List<List<string>> Contributors { get; set; }

    [JsonProperty("buyBoxUsedHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> BuyBoxUsedHistory { get; set; }

    [JsonProperty("lastSoldUpdate", NullValueHandling = NullValueHandling.Ignore)]
    public int? LastSoldUpdate { get; set; }

    [JsonProperty("monthlySold", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonthlySold { get; set; }

    [JsonProperty("monthlySoldHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> MonthlySoldHistory { get; set; }

    [JsonProperty("buyBoxEligibleOfferCounts", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> BuyBoxEligibleOfferCounts { get; set; }

    [JsonProperty("competitivePriceThreshold", NullValueHandling = NullValueHandling.Ignore)]
    public int? CompetitivePriceThreshold { get; set; }

    [JsonProperty("hazardousMaterials", NullValueHandling = NullValueHandling.Ignore)]
    public List<HazardousMaterial> HazardousMaterials { get; set; }

    [JsonProperty("parentAsinHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> ParentAsinHistory { get; set; }

    [JsonProperty("couponHistory", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> CouponHistory { get; set; }

    [JsonProperty("isHeatSensitive", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHeatSensitive { get; set; }

    [JsonProperty("urlSlug", NullValueHandling = NullValueHandling.Ignore)]
    public string UrlSlug { get; set; }

    [JsonProperty("ingredients", NullValueHandling = NullValueHandling.Ignore)]
    public string Ingredients { get; set; }

    [JsonProperty("unitCount", NullValueHandling = NullValueHandling.Ignore)]
    public UnitCount UnitCount { get; set; }

    [JsonProperty("shortDescription", NullValueHandling = NullValueHandling.Ignore)]
    public string ShortDescription { get; set; }

    [JsonProperty("itemForm", NullValueHandling = NullValueHandling.Ignore)]
    public string ItemForm { get; set; }

    [JsonProperty("itemTypeKeyword", NullValueHandling = NullValueHandling.Ignore)]
    public string ItemTypeKeyword { get; set; }

    [JsonProperty("specificUsesForProduct", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> SpecificUsesForProduct { get; set; }

    [JsonProperty("safetyWarning", NullValueHandling = NullValueHandling.Ignore)]
    public string SafetyWarning { get; set; }

    [JsonProperty("productBenefit", NullValueHandling = NullValueHandling.Ignore)]
    public string ProductBenefit { get; set; }

    [JsonProperty("targetAudienceKeyword", NullValueHandling = NullValueHandling.Ignore)]
    public string TargetAudienceKeyword { get; set; }

    [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
    public string Style { get; set; }

    [JsonProperty("material", NullValueHandling = NullValueHandling.Ignore)]
    public string Material { get; set; }

    [JsonProperty("scent", NullValueHandling = NullValueHandling.Ignore)]
    public string Scent { get; set; }

    [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
    public object Stats { get; set; }

    [JsonProperty("offersSuccessful", NullValueHandling = NullValueHandling.Ignore)]
    public bool? OffersSuccessful { get; set; }

    [JsonProperty("g", NullValueHandling = NullValueHandling.Ignore)]
    public int? G { get; set; }

    [JsonProperty("categoryTree", NullValueHandling = NullValueHandling.Ignore)]
    public List<CategoryTree> CategoryTree { get; set; }

    [JsonProperty("parentTitle", NullValueHandling = NullValueHandling.Ignore)]
    public string ParentTitle { get; set; }

    [JsonProperty("referralFeePercent", NullValueHandling = NullValueHandling.Ignore)]
    public int? ReferralFeePercent { get; set; }

    [JsonProperty("referralFeePercentage", NullValueHandling = NullValueHandling.Ignore)]
    public double? ReferralFeePercentage { get; set; }

    [JsonProperty("suggestedLowerPrice", NullValueHandling = NullValueHandling.Ignore)]
    public int? SuggestedLowerPrice { get; set; }

    [JsonProperty("brandStoreName", NullValueHandling = NullValueHandling.Ignore)]
    public string BrandStoreName { get; set; }

    [JsonProperty("brandStoreUrl", NullValueHandling = NullValueHandling.Ignore)]
    public string BrandStoreUrl { get; set; }

    [JsonProperty("brandStoreUrlName", NullValueHandling = NullValueHandling.Ignore)]
    public string BrandStoreUrlName { get; set; }
}

public class Promotion
{
    [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
    public int? Amount { get; set; }

    [JsonProperty("discountPercent", NullValueHandling = NullValueHandling.Ignore)]
    public int? DiscountPercent { get; set; }
}

public class KeepaResponseObj
{
    [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
    public long? Timestamp { get; set; }

    [JsonProperty("tokensLeft", NullValueHandling = NullValueHandling.Ignore)]
    public int? TokensLeft { get; set; }

    [JsonProperty("refillIn", NullValueHandling = NullValueHandling.Ignore)]
    public int? RefillIn { get; set; }

    [JsonProperty("refillRate", NullValueHandling = NullValueHandling.Ignore)]
    public int? RefillRate { get; set; }

    [JsonProperty("tokenFlowReduction", NullValueHandling = NullValueHandling.Ignore)]
    public double? TokenFlowReduction { get; set; }

    [JsonProperty("tokensConsumed", NullValueHandling = NullValueHandling.Ignore)]
    public int? TokensConsumed { get; set; }

    [JsonProperty("processingTimeInMs", NullValueHandling = NullValueHandling.Ignore)]
    public int? ProcessingTimeInMs { get; set; }

    [JsonProperty("products", NullValueHandling = NullValueHandling.Ignore)]
    public List<Product> Products { get; set; }
}

public class SalesRanks
{
    [JsonProperty("3760911", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> _3760911 { get; set; }

    [JsonProperty("11057071", NullValueHandling = NullValueHandling.Ignore)]
    public List<int?> _11057071 { get; set; }
}

public class UnitCount
{
    [JsonProperty("unitValue", NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitValue { get; set; }

    [JsonProperty("unitType", NullValueHandling = NullValueHandling.Ignore)]
    public string UnitType { get; set; }
}

public class Variation
{
    [JsonProperty("asin", NullValueHandling = NullValueHandling.Ignore)]
    public string Asin { get; set; }

    [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
    public List<Attribute> Attributes { get; set; }
}


