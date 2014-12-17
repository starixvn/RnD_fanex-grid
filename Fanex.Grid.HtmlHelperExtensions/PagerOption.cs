namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

        private int _itemsPerPage = 100;

        private int _maxItemsPerPage = 500;

        private int _currentPage = 0;

        private int _totalItem = 0;

        private int _startPerPage = 100;

        private int _pageStep = 50;

        private string _afterPagedFunction = string.Empty;

        private bool _showDetail = true;

        private string[] _itemsPerPageArray;

        private string _customRenderFooterFunction = string.Empty;

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
    }
}
