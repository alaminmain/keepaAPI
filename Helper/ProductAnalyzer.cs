using System;

namespace keepaAPI.Helper
{
    /// <summary>
    /// Provides methods to work on the Keepa price history CSV format.
    /// </summary>
    public static class ProductAnalyzer
    {
        /// <summary>
        /// Finds the extreme points in the specified interval.
        /// </summary>
        public static int[] GetExtremePointsInIntervalWithTime(int[] csv, int start, int end, CsvType type)
        {
            if (csv == null || start >= end || csv.Length < (type.IsWithShipping ? 6 : 4))
                return new int[] { -1, -1, -1, -1 };

            int[] extremeValue = { -1, int.MaxValue, -1, -1 };

            int lastTime = GetLastTime(csv, type);
            int firstTime = csv[0];

            if (lastTime == -1 || firstTime == -1 || firstTime > end) return new int[] { -1, -1, -1, -1 };

            if (firstTime > start) start = firstTime;

            int loopIncrement = type.IsWithShipping ? 3 : 2;
            int adjustedIndex = type.IsWithShipping ? 2 : 1;

            for (int i = 1, j = csv.Length; i < j; i += loopIncrement)
            {
                int c = csv[i];
                int date = csv[i - 1];
                if (date >= end) break;

                if (c != -1)
                {
                    if (type.IsWithShipping)
                    {
                        int s = csv[i + 1];
                        c += s < 0 ? 0 : s;
                    }

                    if (date >= start)
                    {
                        if (c < extremeValue[1])
                        {
                            extremeValue[1] = c;
                            extremeValue[0] = csv[i - 1];
                        }

                        if (c > extremeValue[3])
                        {
                            extremeValue[3] = c;
                            extremeValue[2] = csv[i - 1];
                        }
                    }
                    else
                    {
                        bool isValid = i == j - adjustedIndex || csv[i + adjustedIndex] >= end || csv[i + adjustedIndex] >= start;
                        if (isValid)
                        {
                            if (c < extremeValue[1])
                            {
                                extremeValue[1] = c;
                                extremeValue[0] = start;
                            }

                            if (c > extremeValue[3])
                            {
                                extremeValue[3] = c;
                                extremeValue[2] = start;
                            }
                        }
                    }
                }
            }

            return extremeValue[1] == int.MaxValue ? new int[] { -1, -1, -1, -1 } : extremeValue;
        }

        /// <summary>
        /// Get the last price change delta.
        /// </summary>
        private static int GetDeltaLast(int[] csv, CsvType type)
        {
            if (type.IsWithShipping)
            {
                if (csv == null || csv.Length < 6 || csv[^1] == -1 || csv[^5] == -1) return 0;

                int v = csv[^5], s = csv[^4];
                int totalLast = v < 0 ? v : v + (s < 0 ? 0 : s);

                v = csv[^2];
                s = csv[^1];
                int totalCurrent = v < 0 ? v : v + (s < 0 ? 0 : s);

                return totalCurrent - totalLast;
            }
            else
            {
                if (csv == null || csv.Length < 4 || csv[^1] == -1 || csv[^3] == -1) return 0;
                return csv[^1] - csv[^3];
            }
        }

        /// <summary>
        /// Get the last price.
        /// </summary>
        public static int GetLast(int[] csv, CsvType type)
        {
            if (csv == null || csv.Length == 0) return -1;
            if (type.IsWithShipping)
            {
                int s = csv[^1], v = csv[^2];
                return v < 0 ? v : v + (s < 0 ? 0 : s);
            }
            return csv[^1];
        }

        /// <summary>
        /// Get the last recorded time of price change.
        /// </summary>
        public static int GetLastTime(int[] csv, CsvType type)
        {
            return csv == null || csv.Length == 0 ? -1 : csv[^(type.IsWithShipping ? 3 : 2)];
        }

        /// <summary>
        /// Find the lowest and highest price in the history.
        /// </summary>
        public static int[] GetLowestAndHighest(int[] csv, CsvType type)
        {
            int[] minMax = GetExtremePointsInIntervalWithTime(csv, 0, int.MaxValue, type);
            return new int[] { minMax[1], minMax[3] };
        }

        /// <summary>
        /// Determines if the product was out of stock in a given period.
        /// </summary>
        public static bool? GetOutOfStockInInterval(int[] csv, int start, int end, CsvType type)
        {
            if (type.IsWithShipping && (csv == null || csv.Length < 6)) return null;
            if (start >= end || csv == null || csv.Length < 4) return null;

            int loopIncrement = type.IsWithShipping ? 3 : 2;
            for (int i = 0; i < csv.Length; i += loopIncrement)
            {
                int date = csv[i];
                if (date <= start) continue;
                if (date >= end) break;
                if (csv[i + 1] == -1) return true;
            }
            return false;
        }

        /// <summary>
        /// Get the percentage of time the product was out of stock.
        /// </summary>
        public static int GetOutOfStockPercentageInInterval(int[] csv, int now, int start, int end, CsvType type, int trackingSince)
        {
            if (!type.IsPrice || start >= end || csv == null || csv.Length == 0) return -1;

            int lastTime = GetLastTime(csv, type);
            int firstTime = csv[0];

            if (lastTime == -1 || firstTime == -1 || firstTime > end || trackingSince > end) return -1;

            long count = 0;
            if (trackingSince > start) start = trackingSince;
            if (end > now) end = now;

            int loopIncrement = type.IsWithShipping ? 3 : 2;
            for (int i = 1; i < csv.Length; i += loopIncrement)
            {
                int c = csv[i];
                int date = csv[i - 1];

                if (date >= end) break;

                if (c != -1)
                {
                    int nextDate = i + loopIncrement >= csv.Length ? now : csv[i + loopIncrement];
                    if (nextDate > end) nextDate = end;
                    count += nextDate - date;
                }
            }

            return (int)(count > 0 ? 100 - Math.Floor(count * 100 / (double)(end - start)) : 100);
        }
    }

    public class CsvType
    {
        public bool IsWithShipping { get; set; }
        public bool IsPrice { get; set; }
    }
}
