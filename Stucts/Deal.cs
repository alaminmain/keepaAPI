using System;
using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// Represents a product that has recently changed (usually in price or sales rank).
    /// </summary>
    public class Deal
    {
        /// <summary>
        /// The ASIN of the product.
        /// </summary>
        public string Asin { get; set; }

        /// <summary>
        /// Title of the product. May contain HTML markup in rare cases.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Contains the absolute difference between the current value and the average value of the respective date range interval.
        /// The value 0 means it did not change or could not be calculated.
        /// </summary>
        public int[][] Delta { get; set; }

        /// <summary>
        /// Same as Delta but in percentage.
        /// </summary>
        public short[][] DeltaPercent { get; set; }

        /// <summary>
        /// Contains the absolute difference of the current and the previous price/rank.
        /// </summary>
        public int[] DeltaLast { get; set; }

        /// <summary>
        /// Contains the weighted averages in the respective date range and price type.
        /// </summary>
        public int[][] Avg { get; set; }

        /// <summary>
        /// Contains the prices/ranks of the product at the time of last update.
        /// </summary>
        public int[] Current { get; set; }

        /// <summary>
        /// The category node ID of the product's root category.
        /// </summary>
        public long RootCat { get; set; } = 0L;

        /// <summary>
        /// The time this deal was found, in Keepa Time minutes.
        /// </summary>
        public int CreationDate { get; set; } = 0;

        /// <summary>
        /// The name of the main product image.
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Array of Amazon category node IDs this product is listed in.
        /// </summary>
        public long[] Categories { get; set; }

        /// <summary>
        /// The last time we updated the information for this deal, in Keepa Time minutes.
        /// </summary>
        public int LastUpdate { get; set; } = 0;

        /// <summary>
        /// The time this lightning deal is scheduled to end, in Keepa Time minutes.
        /// </summary>
        public int LightningEnd { get; set; } = 0;

        /// <summary>
        /// Minimum rating filter (integer from 0 to 50, e.g., 45 = 4.5 stars). If -1, the filter is inactive.
        /// </summary>
        public int MinRating { get; set; } = -1;

        /// <summary>
        /// The condition of the cheapest warehouse deal.
        /// 0 - Unknown, 2 - Like New, 3 - Very Good, 4 - Good, 5 - Acceptable.
        /// </summary>
        public byte WarehouseCondition { get; set; }

        /// <summary>
        /// The offer comment of the cheapest warehouse deal. Null if no warehouse deal found.
        /// </summary>
        public string WarehouseConditionComment { get; set; }

        /// <summary>
        /// The timestamp indicating when the current value started, in Keepa Time minutes.
        /// </summary>
        public int[] CurrentSince { get; set; }

        /// <summary>
        /// Available deal ranges.
        /// </summary>
        public enum DealInterval
        {
            Day,
            Week,
            Month,
            _90_Days
        }

        /// <summary>
        /// Returns the JSON representation of the object.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
