using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Represents an Amazon category with various attributes.
    /// </summary>
    public sealed class Category
    {
        /// <summary>
        /// Integer value for the Amazon locale this category belongs to.
        /// </summary>
        public byte DomainId { get; set; }

        /// <summary>
        /// The category node id used by Amazon. Represents the identifier of the category.
        /// Also part of the Product object's categories and rootCategory fields.
        /// Always a positive long value.
        /// </summary>
        public long CatId { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The context-free category name.
        /// </summary>
        public string ContextFreeName { get; set; }

        /// <summary>
        /// The website display group - available for most root categories.
        /// </summary>
        public string WebsiteDisplayGroup { get; set; }

        /// <summary>
        /// List of all subcategories. Null or empty array if the category has no subcategories.
        /// </summary>
        public long[] Children { get; set; }

        /// <summary>
        /// The parent category's Id. Always a positive long value.
        /// If it is 0, the category is a root category and has no parent category.
        /// </summary>
        public long Parent { get; set; }

        /// <summary>
        /// The highest (root category) sales rank observed for a product in this category.
        /// Note: Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
        /// </summary>
        public int HighestRank { get; set; }

        /// <summary>
        /// The lowest (root category) sales rank observed for a product in this category.
        /// Note: Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
        /// </summary>
        public int LowestRank { get; set; }

        /// <summary>
        /// Number of products that are listed in this category.
        /// Note: Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
        /// </summary>
        public int ProductCount { get; set; }

        /// <summary>
        /// Determines if this category functions as a standard browse node, rather than serving promotional purposes.
        /// </summary>
        public bool IsBrowseNode { get; set; }

        /// <summary>
        /// Returns the JSON representation of the object.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
