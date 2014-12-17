namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;

    public class Grid : IHtmlString
    {
        private string _id = "gridId";

        private string _class = "freegrid";

        private string _customClasses = string.Empty;
        //customizeHeader: false,
        private bool _isHeaderCustomized;

        //headerRows: [],
        private List<Row> _headerRows;
        //columns: [],
        private List<Column> _columns;
        //bodyRows: [],
        private List<Row> _bodyRows;

        //numberOfFrozenColumn: 0,
        private int _numberOfFrozenColumn;

        //showFooter: false,
        private bool _showFooter;
        //footerRows: [],
        private List<Row> _footerRows;
        
        //headerColumnHeight: 25,
        private int _headerColumnHeight = 25;
        //bodyRowHeight: 21,
        private int _bodyRowHeight = 21;
        //footerRowHeight: 21,
        private int _footerRowHeight = 21;

        //showTitle: false,
        private bool _showTitle;
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
        private bool _showPager;
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
        private bool _showTree;
        //gridExpandHeight: 150,
        private int _gridExpandHeight = 150;
        //showNoDataOnFrozen: false,
        private bool _showNoDataOnFrozen;
        //showColumnsShowHide: true,
        //enableHiddenColumns: true,
        private bool _enableHiddenColumns = true;
        //showDistinctRow: true,
        private bool _showDistinctRow = true;
        //showHighlightRow: true,
        private bool _showHighlightRow = true;
        //highlightFrozenWidth: 1,
        private int _highlightFrozenWidth = 1;
        //showNumberColumn: false,
        private bool _showNumberColumn;
        //marginRight: 5,
        private int _marginRight = 5;
        //allowTruncate: false,
        private bool _allowTruncate;
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
        private bool _hideYBackGroundScroller;
        //bottomBorderWidth: 1,
        private int _bottomBorderWidth = 1;
        //treeParentPaddingLeft: 20,
        private int _treeParentPaddingLeft = 20;
        //isResetScroller: false,
        private bool _isResetScroller;
        //fullHeight: true,
        private bool _isFullHeight = true;
        //gridHeight: 400,
        private int _gridHeight = 400;
        //gridWidth: 0,
        private int _gridWidth = 0;
        //noDataText: "There is no data",
        //language: 'en-US',
        private string _language = "en-US";
        //autoFixFrozenRowHeight: false,
        private bool _autoFixFrozenRowHeight;
        //autoResizeColumn: false,
        private bool _autoResizeColumn;
        //pixelsPerCharacter: 0,
        private int _pixelsPerCharacter;
        //calTextWidthWithFontSize: true,
        private bool _calTextWidthWithFontSize = true;
        //timeZone: '',
        private string _timeZone = string.Empty;
        //scrollWidth: 24
        private int _scrollWidth = 24;

        public Grid(string id)
        {

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
            _titleOption = titleOption;

            return this;
        }

        public Grid SetPager(PagerOption pagerOption)
        {
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

        public string ToHtmlString()
        {
            throw new NotImplementedException();
        }
    }
}
