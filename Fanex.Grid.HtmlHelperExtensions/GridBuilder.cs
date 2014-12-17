namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web;

    public class GridBuilder : IHtmlString
    {
        /* Grid Options
        customizeHeader: false,
        headerRows: [],
        columns: [],
        bodyRows: [],
        numberOfFrozenColumn: 0,
        showFooter: false,
        footerRows: [],
        showTitle: false,
        headerColumnHeight: 25,
        bodyRowHeight: 21,
        footerRowHeight: 21,
        titleInfo:
        {
            text: "",
            hideWhenNoData: true,
            showExcelButton: false,
            exportExcelFunction: null,
            showBackButton: false,
            backFunction: null,
            showSendMailButton: false,
            sendMailFunction: null,
            showCollapseExpandButton: false,
            customButtons: '',
            showButtonsWhenNoData: false
        },
        showPager: false,
        pagerOption:
        {
            itemsPerPage: 100,
            maxItemsPerPage: 500,
            currentPage: 0,
            totalItem: 0,
            startPerPage: 100,
            pageStep: 50,
            afterPagedFunction: null,
            showDetail: true
        },
        showTree: false,
        gridExpandHeight: 150,
        showNoDataOnFrozen: false,
        showColumnsShowHide: true,
        enableHiddenColumns: true,
        showDistinctRow: true,
        showHighlightRow: true,
        highlightFrozenWidth: 1,
        showNumberColumn: false,
        marginRight: 5,
        allowTruncate: false,
        columnsNeedHide: [],
        hiddenColumns: [],
        sortOption:
        {
            customGridSort: null,
            serverSortFunction: null,
            afterGridSorted: null,
            beforeGridSorted: null
        },
        hideYBackGroundScroller: false,
        bottomBorderWidth: 1,
        treeParentPaddingLeft: 20,
        isResetScroller: false,
        fullHeight: true,
        gridHeight: 400,
        gridWidth: 0,
        noDataText: "There is no data",
        language: 'en-US',
        autoFixFrozenRowHeight: false,
        autoResizeColumn: false,
        pixelsPerCharacter: 0,
        calTextWidthWithFontSize: true,
        timeZone: '',
        scrollWidth: 24
        */
        public GridBuilder(string id)
        {

        }

        public string ToHtmlString()
        {
            throw new NotImplementedException();
        }
    }
}
