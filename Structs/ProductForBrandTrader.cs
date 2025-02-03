using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace keepaAPI.Structs
{
    public class ProductForBrandTrader
    {
        public int Id { get; set; }
        public string? Asin { get; set; }
        public byte? DomainId { get; set; }
        public string? ParentAsin { get; set; }
        public string? VariationCSV { get; set; }
        public List<Upc> UpcList { get; set; }
        public List<Ean> EanList { get; set; }
        public string? ImagesCSV { get; set; }
        public long? RootCategory { get; set; }
        public string? Manufacturer { get; set; }
        public string? Title { get; set; }
        public int? TrackingSince { get; set; }
        public int? ListedSince { get; set; }
        public string? Brand { get; set; }
        public string? ProductGroup { get; set; }
        public string? PartNumber { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Edition { get; set; }
        public string? Format { get; set; }
        public string? Author { get; set; }
        public string? Binding { get; set; }
        public int? NumberOfItems { get; set; }
        public int? NumberOfPages { get; set; }
        public int? PublicationDate { get; set; }
        public int? ReleaseDate { get; set; }
        public string? Features { get; set; }
        public string? Description { get; set; }
        public int? PackageHeight { get; set; }
        public int? PackageLength { get; set; }
        public int? PackageWidth { get; set; }
        public int? PackageWeight { get; set; }
        public int? PackageQuantity { get; set; }
        public int? ItemHeight { get; set; }
        public int? ItemLength { get; set; }
        public int? ItemWidth { get; set; }
        public int? ItemWeight { get; set; }
        public bool? IsAdultProduct { get; set; }
        public bool? IsEligibleForTradeIn { get; set; }
        public bool? IsEligibleForSuperSaverShipping { get; set; }
        public decimal? BuyBoxPrice { get; set; }
        public bool? IsRedirectASIN { get; set; }
        public bool? IsSNS { get; set; }
        public int? LastRatingUpdate { get; set; }
        public int? LastEbayUpdate { get; set; }
        public string? FrequentlyBoughtTogether { get; set; }
        public bool? NewPriceIsMAP { get; set; }
        public int? AvailabilityAmazon { get; set; }
        public List<Variation> Variations { get; set; }
        public int? SalesRankReference { get; set; }
        public int? SalesRanks { get; set; }
        public bool? Launchpad { get; set; }
        public bool? IsB2B { get; set; }
        public int? LastSoldUpdate { get; set; }
        public int? MonthlySold { get; set; }
        public int? CompetitivePriceThreshold { get; set; }
        public string? HazardousMaterials { get; set; }
        public bool? IsHeatSensitive { get; set; }
        public string? UrlSlug { get; set; }
        public string? Ingredients { get; set; }
        public UnitCount UnitCount { get; set; }
        public int? UnitCountId { get; set; }
        public string? ItemForm { get; set; }
        public string? ItemTypeKeyword { get; set; }
        public string? SafetyWarning { get; set; }
        public string? TargetAudienceKeyword { get; set; }
        public string? Style { get; set; }
        public string? Scent { get; set; }
        public bool? OffersSuccessful { get; set; }
        public int? G { get; set; }
        public string? CategoryTree { get; set; }
        public int? ReferralFeePercent { get; set; }
        public double? ReferralFeePercentage { get; set; }
    }

    public class Upc
    {
        [Key]
        public int? Id { get; set; }
        public string? Value { get; set; }
    }

    public class Ean
    {
        [Key]
        public int? Id { get; set; }
        public string? Value { get; set; }
    }
}

