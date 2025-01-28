using Newtonsoft.Json;

namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// The response of a browse deals request.
    /// Each deal product is listed in one root category.
    /// </summary>
    public class DealResponse
    {
        /// <summary>
        /// Ordered array of all deal objects matching your query.
        /// </summary>
        public Deal[] Dr { get; set; }

        /// <summary>
        /// Not yet used / placeholder.
        /// </summary>
        public byte[] DrDateIndex { get; set; }

        /// <summary>
        /// Contains all root categoryIds of the matched deal products.
        /// </summary>
        public long[] CategoryIds { get; set; }

        /// <summary>
        /// Contains all root category names of the matched deal products.
        /// </summary>
        public string[] CategoryNames { get; set; }

        /// <summary>
        /// Contains how many deal products in the respective root category are found.
        /// </summary>
        public int[] CategoryCount { get; set; }

        /// <summary>
        /// Returns the JSON representation of the object.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
