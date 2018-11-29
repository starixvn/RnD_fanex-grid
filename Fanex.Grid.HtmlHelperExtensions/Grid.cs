namespace Fanex.Grid.HtmlHelperExtensions
{
    using System.Collections.Generic;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;
    using Newtonsoft.Json;

    public class Grid
    {
        public string Id { get; private set; } = "gridId";

        public string Class { get; private set; } = "freegrid";

        public string GridOptionsName { get; private set; }

        public string CustomClasses { get; private set; }

        //customizeHeader: false,
        [JsonProperty(PropertyName = "customizeHeader")]
        public bool? IsHeaderCustomized { get; private set; }

        //headerRows: [],
        [JsonProperty(PropertyName = "groupHeaderRows")]
        private List<Row> headerRows;

        //columns: [],
        private List<Column> columns = new List<Column>();

        //bodyRows: [],
        private List<Row> bodyRows;

        //numberOfFrozenColumn: 0,
        public int? NumberOfFrozenColumn { get; private set; }

        //showFooter: false,
        public bool? ShowFooter { get; private set; }

        //footerRows: [],
        private List<Row> footerRows;

        //headerColumnHeight: 25,
        public int? HeaderColumnHeight { get; private set; }

        //bodyRowHeight: 21,
        public int? BodyRowHeight { get; private set; }

        //footerRowHeight: 21,
        public int? FooterRowHeight { get; private set; }

        //showTitle: false,
        public bool? ShowTitle { get; private set; }

        //titleInfo:
        //{
        //    text: "",
        //    hideWhenNoData: true,
        //    showExcelButton: false,
        //    exportExcelFunction: null,
        //    showBackButton: false,
        //    backFunction: null,
        //    showSendMailButton: false,
        //    sendMailFunction: null,
        //    showCollapseExpandButton: false,
        //    customButtons: '',
        //    showButtonsWhenNoData: false
        //},
        [JsonProperty(PropertyName = "titleInfo")]
        public TitleOption TitleOption { get; private set; }

        //showPager: false,
        public bool? ShowPager { get; private set; }

        //pagerOption:
        //{
        //    itemsPerPage: 100,
        //    maxItemsPerPage: 500,
        //    currentPage: 0,
        //    totalItem: 0,
        //    startPerPage: 100,
        //    pageStep: 50,
        //    afterPagedFunction: null,
        //    showDetail: true
        //},
        public PagerOption PagerOption { get; private set; }

        public bool? CustomPager { get; private set; }

        //showTree: false,
        public bool? ShowTree { get; private set; }

        //gridExpandHeight: 150,
        public int? GridExpandHeight { get; private set; }

        //showNoDataOnFrozen: false,
        public bool? ShowNoDataOnFrozen { get; private set; }

        //showColumnsShowHide: true,
        //enableHiddenColumns: true,
        public bool? EnableHiddenColumns { get; private set; }

        //showDistinctRow: true,
        public bool? ShowDistinctRow { get; private set; }

        //showHighlightRow: true,
        public bool? ShowHighlightRow { get; private set; }

        //highlightFrozenWidth: 1,
        public int? HighlightFrozenWidth { get; private set; }

        //showNumberColumn: false,
        public bool? ShowNumberColumn { get; private set; }

        //marginRight: 5,
        public int? MarginRight { get; private set; }

        //allowTruncate: false,
        public bool? AllowTruncate { get; private set; }

        //columnsNeedHide: [],
        //private string[] _columnsNeedHide;
        //hiddenColumns: [],
        public int[] HiddenColumns { get; private set; }

        //sortOption:
        //{
        //    customGridSort: null,
        //    serverSortFunction: null,
        //    afterGridSorted: null,
        //    beforeGridSorted: null
        //},
        public SortOption SortOption { get; private set; }

        //hideYBackGroundScroller: false,
        public bool? HideYBackGroundScroller { get; private set; }

        //bottomBorderWidth: 1,
        public int? BottomBorderWidth { get; private set; }

        //treeParentPaddingLeft: 20,
        public int? TreeParentPaddingLeft { get; private set; }

        //isResetScroller: false,
        public bool? IsResetScroller { get; private set; }

        //fullHeight: true,
        public bool? IsFullHeight { get; private set; }

        //gridHeight: 400,
        public int? GridHeight { get; private set; }

        //gridWidth: 0,
        public int? GridWidth { get; private set; }

        //noDataText: "There is no data",
        //language: 'en-US',
        public string Language { get; private set; }

        //autoFixFrozenRowHeight: false,
        public bool? AutoFixFrozenRowHeight { get; private set; }

        //autoResizeColumn: false,
        public bool? AutoResizeColumn { get; private set; }

        //pixelsPerCharacter: 0,
        public int? PixelsPerCharacter { get; private set; }

        //calTextWidthWithFontSize: true,
        public bool? CalTextWidthWithFontSize { get; private set; }

        //timeZone: '',
        public string TimeZone { get; private set; }

        //scrollWidth: 24
        public int? ScrollWidth { get; private set; }

        public bool? AutoCalculateGridExpandHeight { get; private set; }

        public Grid(string id)
        {
            Id = id;
            GridOptionsName = id.Replace("-", string.Empty) + "Options";
        }

        public Grid SetCustomClasses(string customClasses)
        {
            CustomClasses = customClasses;

            return this;
        }

        public Grid SetHeaderCustomized()
        {
            IsHeaderCustomized = true;
            return this;
        }

        public Grid GroupHeader(List<Row> headerRows)
        {
            IsHeaderCustomized = true;
            this.headerRows = headerRows;
            return this;
        }

        public Grid Column(Column column)
        {
            columns.Add(column);
            return this;
        }

        public Grid Body(List<Row> bodyRows)
        {
            this.bodyRows = bodyRows;
            return this;
        }

        public Grid Footer(List<Row> footerRows)
        {
            ShowFooter = true;
            this.footerRows = footerRows;
            return this;
        }

        public Grid SetFrozenColumns(int numberOfFrozenColumn)
        {
            NumberOfFrozenColumn = numberOfFrozenColumn;
            return this;
        }

        public Grid SetHeaderColumnHeight(int headerColumnHeight)
        {
            HeaderColumnHeight = headerColumnHeight;

            return this;
        }

        public Grid SetBodyRowHeight(int bodyRowHeight)
        {
            BodyRowHeight = bodyRowHeight;

            return this;
        }

        public Grid SetFooterRowHeight(int footerRowHeight)
        {
            FooterRowHeight = footerRowHeight;

            return this;
        }

        public Grid SetTitle(TitleOption titleOption)
        {
            ShowTitle = true;
            TitleOption = titleOption;

            return this;
        }

        public Grid Pager(PagerOption pagerOption, bool customPager = false)
        {
            ShowPager = true;
            CustomPager = customPager;
            PagerOption = pagerOption;

            return this;
        }

        public Grid SetDisplayWithTreeView()
        {
            ShowTree = true;

            return this;
        }

        public Grid SetExpandHeight(int expandHeight)
        {
            GridExpandHeight = expandHeight;

            return this;
        }

        public Grid SetNoDataTextOnFrozenGrid(bool showNoDataOnFrozen)
        {
            ShowNoDataOnFrozen = showNoDataOnFrozen;
            return this;
        }

        public Grid SetHiddenColumnsStatus(bool enable, int[] defaultHiddenColumns = null)
        {
            EnableHiddenColumns = enable;
            HiddenColumns = defaultHiddenColumns;
            return this;
        }

        public Grid SetDistinctRowDisable()
        {
            ShowDistinctRow = false;
            return this;
        }

        public Grid SetHighlightRowDisable()
        {
            ShowHighlightRow = false;
            return this;
        }

        public Grid SetHighlightFrozenWidth(int highlightFrozenWidth)
        {
            HighlightFrozenWidth = highlightFrozenWidth;

            return this;
        }

        public Grid SetNumberColumnVisible()
        {
            ShowNumberColumn = true;

            return this;
        }

        public Grid SetMarginRight(int marginRight)
        {
            MarginRight = marginRight;

            return this;
        }

        public Grid SetAllowedTruncate()
        {
            AllowTruncate = true;

            return this;
        }

        public Grid SetSorting(SortOption sortOption)
        {
            SortOption = sortOption;

            return this;
        }

        public Grid SetYBackgroundScrollerHidden()
        {
            HideYBackGroundScroller = true;

            return this;
        }

        public Grid SetBottomBorderWith(int bottomBorderWidth)
        {
            BottomBorderWidth = bottomBorderWidth;

            return this;
        }

        public Grid SetTreeParentPaddingLeft(int treeParrentPaddingLeft)
        {
            TreeParentPaddingLeft = treeParrentPaddingLeft;

            return this;
        }

        public Grid SetResetScroller(bool isResetScroller)
        {
            IsResetScroller = isResetScroller;
            return this;
        }

        //public Grid SetFullHeight(bool isFullHeight)
        //{
        //    _isFullHeight = isFullHeight;

        //    return this;
        //}

        public Grid SetHeight(int gridHeight)
        {
            GridHeight = gridHeight;
            IsFullHeight = false;

            return this;
        }

        public Grid SetLanguage(string language)
        {
            Language = language;

            return this;
        }

        public Grid SetAutoFixFrozenRowHeight()
        {
            AutoFixFrozenRowHeight = true;

            return this;
        }

        public Grid SetAutoResizeColumn()
        {
            AutoResizeColumn = true;

            return this;
        }

        public Grid SetPixelsPerCharacter(int pixelsPerCharacter)
        {
            PixelsPerCharacter = pixelsPerCharacter;

            return this;
        }

        public Grid SetCalculatingWidthByFontSize(bool isCalTextWidthWithFontSize)
        {
            CalTextWidthWithFontSize = isCalTextWidthWithFontSize;

            return this;
        }

        public Grid SetTimeZone(string timeZone)
        {
            TimeZone = timeZone;

            return this;
        }

        public Grid SetScrollWidth(int scrollWidth)
        {
            ScrollWidth = scrollWidth;

            return this;
        }

        public Grid SetGridOptionsName(string gridOptionsName)
        {
            GridOptionsName = gridOptionsName;

            return this;
        }

        public Grid AutoFullHeight()
        {
            AutoCalculateGridExpandHeight = true;

            return this;
        }

        public string RenderHtml()
        {
            var html = new StringBuilder();
            html.Append($"<div id=\"{Id}-fanex-grid-container\">");

            var fanexGridClass = "freegrid";

            if (!string.IsNullOrEmpty(CustomClasses))
            {
                fanexGridClass += " " + CustomClasses;
            }

            return html
                .Append($"<div id=\"{Id}\" class=\"{fanexGridClass}\">")
                .Append("</div></div>")
                .ToString();
        }

        public string RenderJavascript(string parentElement)
        {
            var script = new StringBuilder();

            script
                .AppendLine("<script type=\"text/javascript\">")
                .AppendLine($"jQuery('{parentElement}').append('{RenderHtml()}')")
                .AppendLine(string.Format("var {0} = null;", GridOptionsName))
                .AppendLine("jQuery(function () {")
                .AppendLine($"{GridOptionsName} = {JsonExtensions.SerializeWithCamelCase(this)};");

            if(headerRows != null)
            {
                script.AppendLine($"{GridOptionsName}.{nameof(headerRows)} = {JsonExtensions.Serialize(headerRows)};");
            }

            if (footerRows != null)
            {
                script.AppendLine($"{GridOptionsName}.{nameof(footerRows)} = {JsonExtensions.Serialize(footerRows)};");
            }

            if (bodyRows != null)
            {
                script.AppendLine($"{GridOptionsName}.{nameof(bodyRows)} = {JsonExtensions.Serialize(bodyRows)};");
            }

            if (columns != null)
            {
                script.AppendLine($"{GridOptionsName}.{nameof(columns)} = {JsonExtensions.Serialize(columns)};");
            }

            return script
                .AppendLine(string.Format("jQuery('#{0}').fanexGrid({1});", Id, GridOptionsName))
                .AppendLine("});")
                .AppendLine("</script>")
                .ToString();
        }

        public string ToHtml(string parentElement)
            => RenderJavascript(parentElement);
    }
}