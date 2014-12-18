namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

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

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptPropertyLine(_customGridSort, "customGridSort");
            script.AppendJavascriptPropertyLine(_serverSortFunction, "serverSortFunction");
            script.AppendJavascriptPropertyLine(_afterGridSorted, "afterGridSorted");
            script.AppendJavascriptPropertyLine(_beforeGridSorted, "beforeGridSorted");

            script.AppendLine("}");

            return script.ToString();
        }
    }
}
