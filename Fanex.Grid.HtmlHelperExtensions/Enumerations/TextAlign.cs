namespace Fanex.Grid.HtmlHelperExtensions.Enumerations
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlign
    {
        Left = 0,

        Center = 1,

        Right = 2
    }
}