namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class PagerOption
    {
        //    itemsPerPage: 100,
        //    maxItemsPerPage: 500,
        //    currentPage: 0,
        //    totalItem: 0,
        //    startPerPage: 100,
        //    pageStep: 50,
        //    afterPagedFunction: null,
        //    showDetail: true

        private int? _itemsPerPage;

        private int? _maxItemsPerPage;

        private int? _currentPage;

        private int? _totalItem;

        private int? _startPerPage;

        private int? _pageStep;

        private string _afterPagedFunction;

        private bool? _showDetail = true;

        private string[] _itemsPerPageArray;

        private string _customRenderFooterFunction;

        public PagerOption SetItemsPerPage(int itemsPerPage)
        {
            _itemsPerPage = itemsPerPage;
            return this;
        }

        public PagerOption SetMaxItemsPerPage(int maxItemsPerPage)
        {
            _maxItemsPerPage = maxItemsPerPage;
            return this;
        }

        public PagerOption SetCurrentPage(int currentPage)
        {
            _currentPage = currentPage;
            return this;
        }

        public PagerOption SetTotalItem(int totalItem)
        {
            _totalItem = totalItem;
            return this;
        }

        public PagerOption SetStartItemPerPage(int startPerPage)
        {
            _startPerPage = startPerPage;
            return this;
        }

        public PagerOption SetPageStep(int pageStep)
        {
            _pageStep = pageStep;
            return this;
        }

        public PagerOption OnAfterPaged(string afterPagedFunction)
        {
            _afterPagedFunction = afterPagedFunction;
            return this;
        }

        public PagerOption SetDetailHidden()
        {
            _showDetail = false;
            return this;
        }

        public PagerOption SetItemsPerPageArray(string[] itemsPerPageArray)
        {
            _itemsPerPageArray = itemsPerPageArray;
            return this;
        }

        public PagerOption SetCustomRenderFooterFunction(string customRenderFooterFunction)
        {
            _customRenderFooterFunction = customRenderFooterFunction;
            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptPropertyLine(_afterPagedFunction, "afterPagedFunction");
            script.AppendJavascriptPropertyLine(_currentPage, "currentPage");
            script.AppendJavascriptPropertyLine(_itemsPerPage, "itemsPerPage");
            script.AppendJavascriptPropertyLine(_maxItemsPerPage, "maxItemsPerPage");
            script.AppendJavascriptPropertyLine(_currentPage, "currentPage");
            script.AppendJavascriptPropertyLine(_totalItem, "totalItem");
            script.AppendJavascriptPropertyLine(_startPerPage, "startPerPage");
            script.AppendJavascriptPropertyLine(_pageStep, "pageStep");
            script.AppendJavascriptPropertyLine(_showDetail, "showDetail");

            script.AppendLine("}");

            return script.ToString();
        }
    }
}
