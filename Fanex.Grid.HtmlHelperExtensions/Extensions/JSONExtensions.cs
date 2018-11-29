namespace Fanex.Grid.HtmlHelperExtensions.Extensions
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    internal static class JsonExtensions
    {
        private static readonly JsonSerializerSettings camelCaseJsonSerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        private static readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string Serialize(object obj)
            => JsonConvert.SerializeObject(obj, jsonSerializerSettings);

        public static string SerializeWithCamelCase(object obj)
            => JsonConvert.SerializeObject(obj, camelCaseJsonSerializerSettings);
    }
}