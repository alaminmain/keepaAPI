using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Contains statistic values. 
    /// Only set if the stats parameter was used in the Product Request.
    /// Part of the Product class.
    /// </summary>
    public class Stats
    {
        public int[] Current { get; set; }
        public int[] Avg { get; set; }
        public int[] Avg30 { get; set; }
        public int[] Avg90 { get; set; }
        public int[] Avg180 { get; set; }
        public int[] Avg365 { get; set; }
        public int[] AtIntervalStart { get; set; }
        public int[][] Min { get; set; }
        public int[][] MinInInterval { get; set; }
        public int[][] Max { get; set; }
        public int[][] MaxInInterval { get; set; }
        public bool[] IsLowest { get; set; }
        public bool[] IsLowest90 { get; set; }
        public int? OutOfStockCountAmazon30 { get; set; }
        public int? OutOfStockCountAmazon90 { get; set; }
        public short? DeltaPercent90_MonthlySold { get; set; }
        public int[] OutOfStockPercentageInInterval { get; set; }
        public int[] OutOfStockPercentage90 { get; set; }
        public int[] OutOfStockPercentage30 { get; set; }
        public int[] LightningDealInfo { get; set; }
        public int TotalOfferCount { get; set; } = -2;
        public int LastOffersUpdate { get; set; } = -1;
        public int[] StockPerCondition3rdFBA { get; set; }
        public int[] StockPerConditionFBM { get; set; }
        public int StockAmazon { get; set; } = -2;
        public int StockBuyBox { get; set; } = -2;
        public int RetrievedOfferCount { get; set; } = -2;
        public int BuyBoxPrice { get; set; } = -2;
        public int BuyBoxShipping { get; set; } = -2;
        public bool? BuyBoxIsUnqualified { get; set; }
        public bool? BuyBoxIsShippable { get; set; }
        public bool? BuyBoxIsPreorder { get; set; }
        public bool? BuyBoxIsFBA { get; set; }
        public int? LastBuyBoxUpdate { get; set; }
        public bool? BuyBoxIsUsed { get; set; }
        public bool? BuyBoxIsBackorder { get; set; }
        public bool? BuyBoxIsAmazon { get; set; }
        public bool? BuyBoxIsMAP { get; set; }
        public int BuyBoxMinOrderQuantity { get; set; } = -1;
        public int BuyBoxMaxOrderQuantity { get; set; } = -1;
        public string BuyBoxAvailabilityMessage { get; set; }
        public string BuyBoxSellerId { get; set; }
        public string BuyBoxShippingCountry { get; set; }
        public bool? BuyBoxIsPrimeExclusive { get; set; }
        public bool? BuyBoxIsFreeShippingEligible { get; set; }
        public bool? BuyBoxIsPrimeEligible { get; set; }
        public bool? BuyBoxIsPrimePantry { get; set; }
        public Dictionary<string, BuyBoxStatsObject> BuyBoxStats { get; set; }
        public int? BuyBoxUsedPrice { get; set; }
        public int? BuyBoxUsedShipping { get; set; }
        public string BuyBoxUsedSellerId { get; set; }
        public bool? BuyBoxUsedIsFBA { get; set; }
        public byte? BuyBoxUsedCondition { get; set; }
        public Dictionary<string, BuyBoxStatsObject> BuyBoxUsedStats { get; set; }
        public bool? IsAddonItem { get; set; }
        public string[] SellerIdsLowestFBA { get; set; }
        public string[] SellerIdsLowestFBM { get; set; }
        public int OfferCountFBA { get; set; } = -2;
        public int OfferCountFBM { get; set; } = -2;
        public int SalesRankDrops30 { get; set; } = -1;
        public int SalesRankDrops90 { get; set; } = -1;
        public int SalesRankDrops180 { get; set; } = -1;
        public int SalesRankDrops365 { get; set; } = -1;

        /// <summary>
        /// Represents Buy Box statistics.
        /// </summary>
        public class BuyBoxStatsObject
        {
            public float PercentageWon { get; set; }
            public int AvgPrice { get; set; }
            public int AvgNewOfferCount { get; set; }
            public bool IsFBA { get; set; }
            public int LastSeen { get; set; }
        }

        /// <summary>
        /// Converts the object to a JSON string.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
