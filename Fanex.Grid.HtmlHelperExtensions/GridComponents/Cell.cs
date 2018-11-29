namespace Fanex.Grid.HtmlHelperExtensions
{
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    [JsonObject(NamingStrategyType = typeof(DefaultNamingStrategy))]
    public class Cell
    {
        public Cell(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public Cell(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public string HeaderText { get; protected set; }

        public object Value { get; private set; }

        public int? MergeRowNumber { get; private set; }

        public int? MergeColNumber { get; private set; }

        public string CustomCellRender { get; private set; }

        public string TdClass { get; private set; }

        public string CssClass { get; private set; }

        public TextAlign? CellAlign { get; private set; }

        public string CustomAttr { get; private set; }

        public Cell SetMergeRowNumber(int mergeRowNumber)
        {
            MergeRowNumber = mergeRowNumber;
            return this;
        }

        public Cell SetHeaderText(string headerText)
        {
            HeaderText = headerText;

            return this;
        }

        public Cell SetMergeColumnNumber(int mergeColumnNumber)
        {
            MergeColNumber = mergeColumnNumber;

            return this;
        }

        public Cell SetCustomCellRender(string customCellRenderFunction)
        {
            CustomCellRender = customCellRenderFunction;
            return this;
        }

        public Cell SetTdClass(string tdClass)
        {
            TdClass = tdClass;
            return this;
        }

        public Cell SetCssClass(string cssClass)
        {
            CssClass = cssClass;
            return this;
        }

        public Cell SetTextAlign(TextAlign textAlign)
        {
            CellAlign = textAlign;
            return this;
        }

        public Cell SetCustomAttributes(string customAttributes)
        {
            CustomAttr = customAttributes;

            return this;
        }
    }
}