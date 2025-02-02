namespace keepaAPI.Helper
{
    using System.Text.Json;

    public static class JsonHelper
    {
        public static List<T> ProcessJsonArray<T>(JsonElement element, Func<string, T> converter)
        {
            var list = new List<T>();

            if (element.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in element.EnumerateArray())
                {
                    list.Add(converter(item.GetString()));
                }
            }

            return list;
        }
    }
}
