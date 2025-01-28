using System;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// A best sellers ASIN list of a specific category.
    /// </summary>
    public class BestSellers
    {
        /// <summary>
        /// Integer value for the Amazon locale this category belongs to.
        /// </summary>
        public byte DomainId { get; set; }

        /// <summary>
        /// States the last time we have updated the list, in Keepa Time minutes.
        /// Use KeepaTime.KeepaMinuteToUnixInMillis(int) to get an uncompressed timestamp (Unix epoch time).
        /// </summary>
        public int LastUpdate { get; set; }

        /// <summary>
        /// The category node id used by Amazon. Represents the identifier of the category.
        /// Also part of the Product object's categories and rootCategory fields.
        /// Always a positive long value or 0 if a product group was used.
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// An ASIN list. The list starts with the best-selling product (lowest sales rank).
        /// </summary>
        public string[] AsinList { get; set; }
    }
}
