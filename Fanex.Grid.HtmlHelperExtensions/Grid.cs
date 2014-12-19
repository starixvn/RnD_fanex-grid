namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class Grid : IHtmlString
    {
        private string _id = "gridId";

        private string _class = "freegrid";

        private string _customClasses;
        //customizeHeader: false,
        private bool? _isHeaderCustomized;

        //headerRows: [],
        private List<Row> _headerRows;
        //columns: [],
        private List<Column> _columns = new List<Column>();
        //bodyRows: [],
        private List<Row> _bodyRows;

        //numberOfFrozenColumn: 0,
        private int? _numberOfFrozenColumn;

        //showFooter: false,
        private bool? _showFooter;
        //footerRows: [],
        private List<Row> _footerRows;
        
        //headerColumnHeight: 25,
        private int? _headerColumnHeight;
        //bodyRowHeight: 21,
        private int? _bodyRowHeight;
        //footerRowHeight: 21,
        private int? _footerRowHeight;

        //showTitle: false,
        private bool? _showTitle;
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
        private TitleOption _titleOption;

        //showPager: false,
        private bool? _showPager;
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
        private PagerOption _pagerOption;

        //showTree: false,
        private bool? _showTree;
        //gridExpandHeight: 150,
        private int? _gridExpandHeight;
        //showNoDataOnFrozen: false,
        private bool? _showNoDataOnFrozen;
        //showColumnsShowHide: true,
        //enableHiddenColumns: true,
        private bool? _enableHiddenColumns;
        //showDistinctRow: true,
        private bool? _showDistinctRow;
        //showHighlightRow: true,
        private bool? _showHighlightRow;
        //highlightFrozenWidth: 1,
        private int? _highlightFrozenWidth;
        //showNumberColumn: false,
        private bool? _showNumberColumn;
        //marginRight: 5,
        private int? _marginRight;
        //allowTruncate: false,
        private bool? _allowTruncate;
        //columnsNeedHide: [],
        //private string[] _columnsNeedHide;
        //hiddenColumns: [],
        private int[] _hiddenColumns;
        //sortOption:
        //{
        //    customGridSort: null,
        //    serverSortFunction: null,
        //    afterGridSorted: null,
        //    beforeGridSorted: null
        //},
        private SortOption _sortOption;

        //hideYBackGroundScroller: false,
        private bool? _hideYBackGroundScroller;
        //bottomBorderWidth: 1,
        private int? _bottomBorderWidth;
        //treeParentPaddingLeft: 20,
        private int? _treeParentPaddingLeft;
        //isResetScroller: false,
        private bool? _isResetScroller;
        //fullHeight: true,
        private bool? _isFullHeight;
        //gridHeight: 400,
        private int? _gridHeight;
        //gridWidth: 0,
        private int? _gridWidth;
        //noDataText: "There is no data",
        //language: 'en-US',
        private string _language;
        //autoFixFrozenRowHeight: false,
        private bool? _autoFixFrozenRowHeight;
        //autoResizeColumn: false,
        private bool? _autoResizeColumn;
        //pixelsPerCharacter: 0,
        private int? _pixelsPerCharacter;
        //calTextWidthWithFontSize: true,
        private bool? _calTextWidthWithFontSize;
        //timeZone: '',
        private string _timeZone;
        //scrollWidth: 24
        private int? _scrollWidth;

        public Grid(string id)
        {
            _id = id;
        }

        public Grid SetCustomClasses(string customClasses)
        {
            _customClasses = customClasses;

            return this;
        }

        public Grid SetHeaderCustomized()
        {
            _isHeaderCustomized = true;
            return this;
        }

        public Grid AddHeaderRows(List<Row> headerRows)
        {
            _headerRows = headerRows;
            return this;
        }

        public Grid AddColumn(Column column)
        {
            _columns.Add(column);
            return this;
        }

        public Grid AddBodyRows(List<Row> bodyRows)
        {
            _bodyRows = bodyRows;
            return this;
        }

        public Grid AddFooterRows(List<Row> footerRows)
        {
            _showFooter = true;
            _footerRows = footerRows;
            return this;
        }

        public Grid SetNumberOfFrozenColumns(int numberOfFrozenColumn)
        {
            _numberOfFrozenColumn = numberOfFrozenColumn;
            return this;
        }

        public Grid SetHeaderColumnHeight(int headerColumnHeight)
        {
            _headerColumnHeight = headerColumnHeight;

            return this;
        }

        public Grid SetBodyRowHeight(int bodyRowHeight)
        {
            _bodyRowHeight = bodyRowHeight;

            return this;
        }

        public Grid SetFooterRowHeight(int footerRowHeight)
        {
            _footerRowHeight = footerRowHeight;

            return this;
        }

        public Grid SetTitle(TitleOption titleOption)
        {
            _showTitle = true;
            _titleOption = titleOption;

            return this;
        }

        public Grid SetPager(PagerOption pagerOption)
        {
            _showPager = true;
            _pagerOption = pagerOption;

            return this;
        }

        public Grid SetDisplayWithTreeView()
        {
            _showTree = true;

            return this;
        }

        public Grid SetExpandHeight(int expandHeight)
        {
            _gridExpandHeight = expandHeight;

            return this;
        }

        public Grid SetNoDataTextOnFrozenGrid(bool showNoDataOnFrozen)
        {
            _showNoDataOnFrozen = showNoDataOnFrozen;
            return this;
        }

        public Grid SetHiddenColumnsStatus(bool enable)
        {
            _enableHiddenColumns = enable;
            return this;
        }

        public Grid SetDistinctRowDisable()
        {
            _showDistinctRow = false;
            return this;
        }

        public Grid SetHighlightRowDisable()
        {
            _showHighlightRow = false;
            return this;
        }

        public Grid SetHighlightFrozenWidth(int highlightFrozenWidth)
        {
            _highlightFrozenWidth = highlightFrozenWidth;

            return this;
        }

        public Grid SetNumberColumnVisible()
        {
            _showNumberColumn = true;

            return this;
        }

        public Grid SetMarginRight(int marginRight)
        {
            _marginRight = marginRight;

            return this;
        }

        public Grid SetAllowedTruncate()
        {
            _allowTruncate = true;

            return this;
        }

        public Grid SetHiddenColumns(int[] hiddenColumns)
        {
            _hiddenColumns = hiddenColumns;

            return this;
        }

        public Grid SetSorting(SortOption sortOption)
        {
            _sortOption = sortOption;

            return this;
        }

        public Grid SetYBackgroundScrollerHidden()
        {
            _hideYBackGroundScroller = true;

            return this;
        }

        public Grid SetBottomBorderWith(int bottomBorderWidth)
        {
            _bottomBorderWidth = bottomBorderWidth;

            return this;
        }

        public Grid SetTreeParentPaddingLeft(int treeParrentPaddingLeft)
        {
            _treeParentPaddingLeft = treeParrentPaddingLeft;

            return this;
        }

        public Grid SetResetScroller(bool isResetScroller)
        {
            _isResetScroller = isResetScroller;
            return this;
        }

        //public Grid SetFullHeight(bool isFullHeight)
        //{
        //    _isFullHeight = isFullHeight;

        //    return this;
        //}

        public Grid SetHeight(int gridHeight)
        {
            _gridHeight = gridHeight;
            _isFullHeight = false;

            return this;
        }

        public Grid SetLanguage(string language)
        {
            _language = language;

            return this;
        }

        public Grid SetAutoFixFrozenRowHeight()
        {
            _autoFixFrozenRowHeight = true;

            return this;
        }

        public Grid SetAutoResizeColumn()
        {
            _autoResizeColumn = true;

            return this;
        }

        public Grid SetPixelsPerCharacter(int pixelsPerCharacter)
        {
            _pixelsPerCharacter = pixelsPerCharacter;

            return this;
        }

        public Grid SetCalculatingWidthByFontSize(bool isCalTextWidthWithFontSize)
        {
            _calTextWidthWithFontSize = isCalTextWidthWithFontSize;

            return this;
        }

        public Grid SetTimeZone(string timeZone)
        {
            _timeZone = timeZone;

            return this;
        }

        public Grid SetScrollWidth(int scrollWidth)
        {
            _scrollWidth = scrollWidth;

            return this;
        }

        public string RenderHtml()
        {
            var html = new StringBuilder();

            //<div id="sourcecontainer">
            //    <div id="gridId" class="freegrid  content-grid">
            //    </div>
            //</div>

            html.AppendLine(string.Format("<div id=\"{0}-fanex-grid-container\">", _id));

            var fanexGridClass = "freegrid";

            if(!string.IsNullOrEmpty(_customClasses))
            {
                fanexGridClass += " " + _customClasses;
            }

            html.AppendLine(string.Format("<div id=\"{0}\" class=\"{1}\">", _id, fanexGridClass));

            html.AppendLine("</div></div>");

            return html.ToString();
        }

        public string RenderJavascript()
        {
            // Create javascript
            var script = new StringBuilder();

            script.AppendLine("<script type=\"text/javascript\">");
            script.AppendLine("jQuery(function () {");

            script.AppendLine("jQuery('#" + _id + "').fanexGrid({");

            script.AppendJavascriptProperty(_isHeaderCustomized, "customizeHeader");
            script.AppendJavascriptProperty(_numberOfFrozenColumn, "numberOfFrozenColumn");
            script.AppendJavascriptProperty(_headerColumnHeight, "headerColumnHeight");
            script.AppendJavascriptProperty(_bodyRowHeight, "bodyRowHeight");
            script.AppendJavascriptProperty(_footerRowHeight, "footerRowHeight");
            script.AppendJavascriptProperty(_showTree, "showTree");
            script.AppendJavascriptProperty(_gridExpandHeight, "gridExpandHeight");
            script.AppendJavascriptProperty(_showNoDataOnFrozen, "showNoDataOnFrozen");
            script.AppendJavascriptProperty(_enableHiddenColumns, "enableHiddenColumns");
            script.AppendJavascriptProperty(_showDistinctRow, "showDistinctRow");
            script.AppendJavascriptProperty(_showHighlightRow, "showHighlightRow");
            script.AppendJavascriptProperty(_highlightFrozenWidth, "highlightFrozenWidth");
            script.AppendJavascriptProperty(_showNumberColumn, "showNumberColumn");
            script.AppendJavascriptProperty(_marginRight, "marginRight");
            script.AppendJavascriptProperty(_allowTruncate, "allowTruncate");
            script.AppendJavascriptProperty(_hideYBackGroundScroller, "hideYBackGroundScroller");
            script.AppendJavascriptProperty(_bottomBorderWidth, "bottomBorderWidth");
            script.AppendJavascriptProperty(_treeParentPaddingLeft, "treeParentPaddingLeft");
            script.AppendJavascriptProperty(_isResetScroller, "isResetScroller");
            script.AppendJavascriptProperty(_isFullHeight, "fullHeight");
            script.AppendJavascriptProperty(_gridHeight, "gridHeight");
            script.AppendJavascriptProperty(_language, "language");
            script.AppendJavascriptProperty(_autoFixFrozenRowHeight, "autoFixFrozenRowHeight");
            script.AppendJavascriptProperty(_autoResizeColumn, "autoResizeColumn");
            script.AppendJavascriptProperty(_pixelsPerCharacter, "pixelsPerCharacter");
            script.AppendJavascriptProperty(_calTextWidthWithFontSize, "calTextWidthWithFontSize");
            script.AppendJavascriptProperty(_timeZone, "timeZone");
            script.AppendJavascriptProperty(_scrollWidth, "scrollWidth");
            script.AppendJavascriptProperty(_calTextWidthWithFontSize, "calTextWidthWithFontSize");

            script.AppendJavascriptProperty(_showTitle, "showTitle");
            script.AppendJavascriptProperty(_titleOption, "titleInfo");

            script.AppendJavascriptProperty(_showPager, "showPager");
            script.AppendJavascriptProperty(_pagerOption, "pagerOption");

            script.AppendJavascriptProperty(_sortOption, "sortOption");

            script.AppendJavascriptPropertyLine<Row>(_bodyRows, "bodyRows");
            script.AppendJavascriptPropertyLine<Column>(_columns, "columns");
            script.AppendJavascriptPropertyLine<Row>(_headerRows, "headerRows");

            script.AppendJavascriptProperty(_showFooter, "showFooter");
            script.AppendJavascriptPropertyLine<Row>(_footerRows, "footerRows");
            //script.AppendJavascriptProperty(_titleOption, "titleInfo");
            //script.AppendJavascriptProperty(_titleOption, "titleInfo");

            //if (_pagerOption != null)
            //{
            //    script.AppendLine("showFooter:true,");
            //}

            script.AppendLine("});");

            script.AppendLine("});");
            script.AppendLine("</script>");

            return script.ToString();
        }


        public string ToHtmlString()
        {
            return RenderHtml() + RenderJavascript();
        }
    }
}
