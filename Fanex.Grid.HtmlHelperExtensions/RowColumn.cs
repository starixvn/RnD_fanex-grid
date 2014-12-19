namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class RowColumn
    {
        public RowColumn(string name, object value)
        {
            _name = name;
            _value = value;
        }

        private string _name;

        private object _value;

        private int? _mergeRowNumber;

        private int? _mergeColNumner;

        private string _customCellRender;

        private string _tdClass;

        private string _cssClass;

        private TextAlign? _cellAlign;

        private string _customAttributes;

        public RowColumn SetMergeRowNumber(int mergeRowNumber)
        {
            _mergeRowNumber = mergeRowNumber;
            return this;
        }

        public RowColumn SetMergeColumnNumber(int mergeColumnNumber)
        {
            _mergeColNumner = mergeColumnNumber;

            return this;
        }

        public RowColumn SetCustomCellRender(string customCellRenderFunction)
        {
            _customCellRender = customCellRenderFunction;
            return this;
        }

        public RowColumn SetTdClass(string tdClass)
        {
            _tdClass = tdClass;
            return this;
        }

        public RowColumn SetCssClass(string cssClass)
        {
            _cssClass = cssClass;
            return this;
        }

        public RowColumn SetTextAlign(TextAlign textAlign)
        {
            _cellAlign = textAlign;
            return this;
        }

        public RowColumn SetCustomAttributes(string customAttributes)
        {
            _customAttributes = customAttributes;

            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptPropertyLine(_name, "Name");
            script.AppendJavascriptPropertyLine(_mergeRowNumber, "MergeRowNumber");
            script.AppendJavascriptPropertyLine(_mergeColNumner, "MergeColNumber");
            script.AppendJavascriptPropertyLine(_customCellRender, "CustomCellRender");
            script.AppendJavascriptPropertyLine(_tdClass, "TdClass");
            script.AppendJavascriptPropertyLine(_cssClass, "CssClass");
            script.AppendJavascriptPropertyLine(_cellAlign, "CellAlign");
            script.AppendJavascriptPropertyLine(_customAttributes, "CustomAttr");

            script.AppendLine("Value:" + _value.ToJSON());

            script.AppendLine("},");

            return script.ToString();
        }
    }
}
