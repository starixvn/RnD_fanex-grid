namespace Fanex.Grid.HtmlHelperExtensions
{
    public class SortOption
    {
        //    customGridSort: null,
        //    serverSortFunction: null,
        //    afterGridSorted: null,
        //    beforeGridSorted: null

        public string CustomGridSort { get; private set; }

        public string ServerSortFunction { get; private set; }

        public string AfterGridSorted { get; private set; }

        public string BeforeGridSorted { get; private set; }

        public SortOption SetCustomGridSortFunction(string customGridSortFunction)
        {
            CustomGridSort = customGridSortFunction;
            return this;
        }

        public SortOption SetServerSortFunction(string serverSortFunction)
        {
            ServerSortFunction = serverSortFunction;

            return this;
        }

        public SortOption OnAfterGridSorted(string afterGridSortedFunction)
        {
            AfterGridSorted = afterGridSortedFunction;

            return this;
        }

        public SortOption OnBeforeGridSort(string beforeGridSortFunction)
        {
            BeforeGridSorted = beforeGridSortFunction;

            return this;
        }
    }
}