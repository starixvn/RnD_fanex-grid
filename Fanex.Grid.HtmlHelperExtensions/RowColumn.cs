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
            var isBreakNewLine = false;
            var script = new StringBuilder();

            script.Append("{");

            script.AppendJavascriptProperty(_name, "Name", isBreakNewLine);
            script.AppendJavascriptProperty(_mergeRowNumber, "MergeRowNumber", isBreakNewLine);
            script.AppendJavascriptProperty(_mergeColNumner, "MergeColNumber", isBreakNewLine);
            script.AppendJavascriptProperty(_customCellRender, "CustomCellRender", isBreakNewLine);
            script.AppendJavascriptProperty(_tdClass, "TdClass", isBreakNewLine);
            script.AppendJavascriptProperty(_cssClass, "CssClass", isBreakNewLine);
            script.AppendJavascriptProperty(_cellAlign, "CellAlign", isBreakNewLine);
            script.AppendJavascriptProperty(_customAttributes, "CustomAttr", isBreakNewLine);

            script.Append("Value:" + _value.ToJSON());

            script.AppendLine("},");

            return script.ToString();
        }
    }
}
