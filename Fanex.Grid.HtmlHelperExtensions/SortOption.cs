namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SortOption
    {

        //    customGridSort: null,
        //    serverSortFunction: null,
        //    afterGridSorted: null,
        //    beforeGridSorted: null

        private string _customGridSort;

        private string _serverSortFunction;

        private string _afterGridSorted;

        private string _beforeGridSorted;

        public SortOption SetCustomGridSortFunction(string customGridSortFunction)
        {
            _customGridSort = customGridSortFunction;
            return this;
        }

        public SortOption SetServerSortFunction(string serverSortFunction)
        {
            _serverSortFunction = serverSortFunction;

            return this;
        }

        public SortOption OnAfterGridSorted(string afterGridSortedFunction)
        {
            _afterGridSorted = afterGridSortedFunction;

            return this;
        }

        public SortOption OnBeforeGridSort(string beforeGridSortFunction)
        {
            _beforeGridSorted = beforeGridSortFunction;

            return this;
        }

    }
}
