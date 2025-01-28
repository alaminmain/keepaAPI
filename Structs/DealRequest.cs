using System;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Required by the Browsing Deals request.
    /// The queryJSON contains all request parameters.
    /// </summary>
    public class DealRequest
    {
        /// <summary>
        /// Used to browse paginated deals (max 150 per page). Starts from 0.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The domainId of the products Amazon locale.
        /// </summary>
        public int DomainId { get; set; }

        /// <summary>
        /// Determines the type of the deal. Multiple types per query are not yet supported.
        /// </summary>
        public int[] PriceTypes { get; set; }

        /// <summary>
        /// The time interval in which the product changed.
        /// 0 - day, 1 - week, 2 - month, 3 - 90 days.
        /// </summary>
        public int DateRange { get; set; }

        /// <summary>
        /// Limit the range of the absolute difference between the current value and the one at the beginning of the chosen DateRange interval.
        /// </summary>
        public int[] DeltaRange { get; set; }

        /// <summary>
        /// Exclude products in these categories.
        /// </summary>
        public long[] ExcludeCategories { get; set; }

        /// <summary>
        /// Include products in these categories.
        /// </summary>
        public long[] IncludeCategories { get; set; }

        /// <summary>
        /// Same as DeltaRange but in percentage.
        /// </summary>
        public int[] DeltaPercentRange { get; set; }

        /// <summary>
        /// Limit the range of the current value of the price type.
        /// </summary>
        public int[] CurrentRange { get; set; }

        public bool IsLowest { get; set; }
        public string TitleSearch { get; set; }
        public bool IsLowestOffer { get; set; }
        public bool IsBackInStock { get; set; }
        public bool IsOutOfStock { get; set; }
        public bool IsRangeEnabled { get; set; }
        public bool FilterErotic { get; set; }

        /// <summary>
        /// Determines the sort order of the retrieved deals.
        /// </summary>
        public int SortType { get; set; }

        /// <summary>
        /// Limit the Sales Rank range of the product.
        /// </summary>
        public int[] SalesRankRange { get; set; }

        public bool IsFilterEnabled { get; set; }

        /// <summary>
        /// Limit the range of the absolute difference between the current value and the previous one.
        /// </summary>
        public int[] DeltaLastRange { get; set; }

        public bool HasReviews { get; set; }
        public string CategorySearch { get; set; }
        public bool IsPrimeExclusive { get; set; }
        public bool MustHaveAmazonOffer { get; set; }
        public bool MustNotHaveAmazonOffer { get; set; }
        public int? MinRating { get; set; }
        public byte[] WarehouseConditions { get; set; }
        public bool? SingleVariation { get; set; }

        public string[] Material { get; set; }
        public string[] Type { get; set; }
        public string[] Manufacturer { get; set; }
        public string[] Brand { get; set; }
        public string[] ProductGroup { get; set; }
        public string[] Model { get; set; }
        public string[] Color { get; set; }
        public string[] Size { get; set; }
        public string[] UnitType { get; set; }
        public string[] Scent { get; set; }
        public string[] ItemForm { get; set; }
        public string[] Pattern { get; set; }
        public string[] Style { get; set; }
        public string[] ItemTypeKeyword { get; set; }
        public string[] TargetAudienceKeyword { get; set; }
        public string[] Edition { get; set; }
        public string[] Format { get; set; }
        public string[] Author { get; set; }
        public string[] Binding { get; set; }
        public string[] Languages { get; set; }

        /// <summary>
        /// Returns the JSON representation of the object.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
