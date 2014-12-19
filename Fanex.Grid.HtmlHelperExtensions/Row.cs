namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class Row
    {
        private string _cssClass;

        private string _customAttributes;

        private List<RowColumn> _columns = new List<RowColumn>();

        private List<Row> _subRows;

        public Row AddColumns(List<RowColumn> columns)
        {
            _columns.AddRange(columns);

            return this;
        }

        public Row AddColumn(RowColumn column)
        {
            _columns.Add(column);

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
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptPropertyLine(_cssClass, "CssClass");
            script.AppendJavascriptPropertyLine(_customAttributes, "CustomAttr");
            script.AppendJavascriptPropertyLine<Row>(_subRows, "SubRows");
            script.AppendJavascriptPropertyLine<RowColumn>(_columns, "Columns");

            script.AppendLine("}");

            return script.ToString();
        }
    }
}
