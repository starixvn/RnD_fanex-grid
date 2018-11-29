namespace Fanex.Grid.HtmlHelperExtensions
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]

    public class HeaderColumn : Cell
    {
        public HeaderColumn(string name, string headerText) : base(name, null)
        {
            HeaderText = headerText;
        }
    }
}