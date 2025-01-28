using System;
using System.Linq;
using System.Net;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace keepaAPI.Helper
{
    /// <summary>
    /// Static helper methods and reused objects.
    /// </summary>
    public static class Utility
    {
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(),
                IgnoreSerializableInterface = true
            },
            Formatting = Newtonsoft.Json.Formatting.None
        };

        public static readonly JsonSerializerSettings JsonSerializerPrettySettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(),
                IgnoreSerializableInterface = true
            },
            Formatting = Formatting.Indented
        };

        /// <summary>
        /// Converts an array of strings to a CSV formatted string.
        /// </summary>
        public static string ArrayToCsv(string[] array)
        {
            return array != null ? string.Join(",", array) : string.Empty;
        }

        /// <summary>
        /// URL encodes a string using UTF-8.
        /// </summary>
        public static string UrlEncodeUTF8(string s)
        {
            return WebUtility.UrlEncode(s);
        }
    }
}
