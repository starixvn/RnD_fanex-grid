namespace Fanex.Grid.HtmlHelperExtensions
{
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    [JsonObject(NamingStrategyType = typeof(DefaultNamingStrategy))]
    public class Column
    {
        public Column(string name, string headerText, int width)
        {
            Name = name;
            HeaderText = headerText;
            Width = width;
        }

        public string HeaderText { get; private set; }

        public string Name { get; private set; }

        public int Width { get; private set; }

        public string CssClass { get; private set; }

        public string TdClass { get; private set; }

        public string CellCssClass { get; private set; }

        public TextAlign? HeaderAlign { get; private set; }

        public TextAlign? CellAlign { get; private set; }

        [JsonProperty(PropertyName = "Sort")]
        public bool? IsSortable { get; private set; }

        public string FormatNumber { get; private set; }

        public string FormatNegative { get; private set; }

        public string FormatPositive { get; private set; }

        [JsonProperty(PropertyName = "ShowCollapseExpand")]
        public bool? ShowCollapseExpandIcon { get; private set; }

        public bool? AllowTruncate { get; private set; }

        public string CustomHeaderRender { get; private set; }

        public string CustomCellRender { get; private set; }

        public string SortDirection { get; private set; }

        public string CustomSortFunction { get; private set; }

        public string SortType { get; private set; }

        public Column SetCssClass(string cssClass)
        {
            CssClass = cssClass;

            return this;
        }

        public Column SetTdClass(string tdClass)
        {
            TdClass = tdClass;
            return this;
        }

        public Column SetCellCssClass(string cellCssClass)
        {
            CellCssClass = cellCssClass;

            return this;
        }

        public Column SetHeaderTextAlign(TextAlign headerTextAlign)
        {
            HeaderAlign = headerTextAlign;
            return this;
        }

        public Column SetCellTextAlign(TextAlign cellTextAlign)
        {
            CellAlign = cellTextAlign;
            return this;
        }

        public Column SetSortable(string sortDirection = "", string customSortFunction = "", string sortType = "")
        {
            if (!string.IsNullOrEmpty(sortDirection))
            {
                SortDirection = sortDirection;
            }

            if (!string.IsNullOrEmpty(customSortFunction))
            {
                CustomSortFunction = customSortFunction;
            }

            if (!string.IsNullOrEmpty(sortType))
            {
                SortType = sortType;
            }

            IsSortable = true;
            return this;
        }

        public Column SetFormatNumber(string formatNumber)
        {
            FormatNumber = formatNumber;
            return this;
        }

        public Column SetFormatNegative(string formatNegative)
        {
            FormatNegative = formatNegative;
            return this;
        }

        public Column SetFormatPositive(string formatPositive)
        {
            FormatPositive = formatPositive;
            return this;
        }

        public Column SetCollapseExpandIcon()
        {
            ShowCollapseExpandIcon = true;
            return this;
        }

        public Column SetTextTruncate()
        {
            AllowTruncate = true;
            return this;
        }

        public Column SetCustomHeaderRender(string customHeaderRenderFunction)
        {
            CustomHeaderRender = customHeaderRenderFunction;
            return this;
        }

        public Column SetCustomCellRender(string customCellRenderFunction)
        {
            CustomCellRender = customCellRenderFunction;
            return this;
        }
    }
}