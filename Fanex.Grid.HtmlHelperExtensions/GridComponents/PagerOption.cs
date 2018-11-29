namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;
    using Newtonsoft.Json;

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

        public PagerOption(int itemsPerPage, int[] itemsPerPageArray, int currentPage = 0)
        {
            CurrentPage = currentPage;
            ItemsPerPage = itemsPerPage;
            ItemsPerPageArray = itemsPerPageArray;
        }

        public int? ItemsPerPage { get; private set; }

        public int? MaxItemsPerPage { get; private set; }

        public int? CurrentPage { get; private set; }

        public int? TotalItem { get; private set; }

        public int? StartPerPage { get; private set; }

        public int? PageStep { get; private set; }

        public string AfterPagedFunction { get; private set; }

        public bool? ShowDetail { get; private set; } = true;

        public int[] ItemsPerPageArray { get; private set; }

        [JsonProperty(PropertyName = "customRenderFooter")]
        public string CustomRenderFooterFunction { get; private set; }

        public string PagerSelectCallBack { get; private set; }

        public PagerOption SetItemsPerPage(int itemsPerPage)
        {
            ItemsPerPage = itemsPerPage;
            return this;
        }

        public PagerOption SetMaxItemsPerPage(int maxItemsPerPage)
        {
            MaxItemsPerPage = maxItemsPerPage;
            return this;
        }

        public PagerOption SetCurrentPage(int currentPage)
        {
            CurrentPage = currentPage;
            return this;
        }

        public PagerOption SetTotalItem(int totalItem)
        {
            TotalItem = totalItem;
            return this;
        }

        public PagerOption SetStartItemPerPage(int startPerPage)
        {
            StartPerPage = startPerPage;
            return this;
        }

        public PagerOption SetPageStep(int pageStep)
        {
            PageStep = pageStep;
            return this;
        }

        public PagerOption OnAfterPaged(string afterPagedFunction)
        {
            AfterPagedFunction = afterPagedFunction;
            return this;
        }

        public PagerOption SetDetailHidden()
        {
            ShowDetail = false;
            return this;
        }

        public PagerOption SetItemsPerPageArray(int[] itemsPerPageArray)
        {
            ItemsPerPageArray = itemsPerPageArray;
            return this;
        }

        public PagerOption OnRenderFooter(string customRenderFooterFunction)
        {
            CustomRenderFooterFunction = customRenderFooterFunction;
            return this;
        }

        public PagerOption OnPageSelect(string pageSelectCallBackFunction)
        {
            PagerSelectCallBack = pageSelectCallBackFunction;
            return this;
        }
    }
}
