namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Row
    {
        private string _cssClass = string.Empty;

        private string _customAttributes = string.Empty;

        private List<RowColumn> _columns;

        private List<Row> _subRows;

        public Row AddColumns(List<RowColumn> columns)
        {
            _columns = columns;

            return this;
        }

        public Row AddSubRows(List<Row> subRows)
        {
            _subRows = subRows;

            return this;
        }

        public Row SetCssClass(string cssClass)
        {
            _cssClass = cssClass;

            return this;
        }

        public Row SetCustomAttributes(string customAttributes)
        {
            _customAttributes = customAttributes;

            return this;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
