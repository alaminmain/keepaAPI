using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace keepaAPI.Structs
{
    public class ProductForBrandTrader
    {
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

        [JsonPropertyName("features")]
        public string Features { get; set; }

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

        public decimal BuyBoxPrice { get; set; }

        [JsonPropertyName("isRedirectASIN")]
        public bool IsRedirectASIN { get; set; }

        [JsonPropertyName("isSNS")]
        public bool IsSNS { get; set; }

        [JsonPropertyName("lastRatingUpdate")]
        public int LastRatingUpdate { get; set; }

        [JsonPropertyName("ebayListingIds")]
        public string EbayListingIds { get; set; }

        [JsonPropertyName("lastEbayUpdate")]
        public int LastEbayUpdate { get; set; }

        [JsonPropertyName("frequentlyBoughtTogether")]
        public string FrequentlyBoughtTogether { get; set; }

        [JsonPropertyName("newPriceIsMAP")]
        public bool NewPriceIsMAP { get; set; }

        [JsonPropertyName("availabilityAmazon")]
        public int AvailabilityAmazon { get; set; }

        [JsonPropertyName("variations")]
        public List<Variation> Variations { get; set; }

        [JsonPropertyName("salesRankReference")]
        public int SalesRankReference { get; set; }

        [JsonPropertyName("salesRanks")]
        public int SalesRanks { get; set; }

        [JsonPropertyName("launchpad")]
        public bool Launchpad { get; set; }

        [JsonPropertyName("isB2B")]
        public bool IsB2B { get; set; }

        [JsonPropertyName("lastSoldUpdate")]
        public int LastSoldUpdate { get; set; }

        [JsonPropertyName("monthlySold")]
        public int MonthlySold { get; set; }

        [JsonPropertyName("competitivePriceThreshold")]
        public int CompetitivePriceThreshold { get; set; }

        [JsonPropertyName("hazardousMaterials")]
        public string HazardousMaterials { get; set; }

        [JsonPropertyName("isHeatSensitive")]
        public bool IsHeatSensitive { get; set; }

        [JsonPropertyName("urlSlug")]
        public string UrlSlug { get; set; }

        [JsonPropertyName("ingredients")]
        public string Ingredients { get; set; }

        [JsonPropertyName("unitCount")]
        public UnitCount UnitCount { get; set; }
        public int UnitCountId { get; set; } // Foreign key property

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

        [JsonPropertyName("offersSuccessful")]
        public bool OffersSuccessful { get; set; }

        [JsonPropertyName("g")]
        public int G { get; set; }

        [JsonPropertyName("categoryTree")]
        public string CategoryTree { get; set; }

        [JsonPropertyName("referralFeePercent")]
        public int ReferralFeePercent { get; set; }

        [JsonPropertyName("referralFeePercentage")]
        public double ReferralFeePercentage { get; set; }
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
}

