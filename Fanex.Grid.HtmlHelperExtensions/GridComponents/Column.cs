

namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class Column
    {
        public Column(string name, string headerText, int width)
        {
            _name = name;
            _headerText = headerText;
            _width = width;
        }

        private string _headerText = string.Empty;

        private string _name = string.Empty;

        private int _width;

        private string _cssClass = string.Empty;

        private string _tdClass = string.Empty;

        private string _cellCssClass = string.Empty;

        private TextAlign? _headerAlign;

        private TextAlign? _cellAlign;

        private bool? _isSortable;

        private string _formatNumber = string.Empty;

        private string _formatNegative = string.Empty;

        private string _formatPositive = string.Empty;

        private bool? _showCollapseExpandIcon;

        private bool? _allowTruncate;

        private string _customHeaderRender = string.Empty;

        private string _customCellRender = string.Empty;

        public Column SetCssClass(string cssClass)
        {
            _cssClass = cssClass;

            return this;
        }

        public Column SetTdClass(string tdClass)
        {
            _tdClass = tdClass;
            return this;
        }

        public Column SetCellCssClass(string cellCssClass)
        {
            _cellCssClass = cellCssClass;

            return this;
        }

        public Column SetHeaderTextAlign(TextAlign headerTextAlign)
        {
            _headerAlign = headerTextAlign;
            return this;
        }

        public Column SetCellTextAlign(TextAlign cellTextAlign)
        {
            _cellAlign = cellTextAlign;
            return this;
        }

        public Column SetSortable()
        {
            _isSortable = true;
            return this;
        }

        public Column SetFormatNumber(string formatNumber)
        {
            _formatNumber = formatNumber;
            return this;
        }

        public Column SetFormatNegative(string formatNegative)
        {
            _formatNegative = formatNegative;
            return this;
        }

        public Column SetFormatPositive(string formatPositive)
        {
            _formatPositive = formatPositive;
            return this;
        }

        public Column SetCollapseExpandIcon()
        {
            _showCollapseExpandIcon = true;
            return this;
        }

        public Column SetTextTruncate()
        {
            _allowTruncate = true;
            return this;
        }

        public Column SetCustomHeaderRender(string customHeaderRenderFunction)
        {
            _customHeaderRender = customHeaderRenderFunction;
            return this;
        }

        public Column SetCustomCellRender(string customCellRenderFunction)
        {
            _customCellRender = customCellRenderFunction;
            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");
            script.AppendLine(_headerText.ToJavascriptProperty("HeaderText"));
            script.AppendLine(_name.ToJavascriptProperty("Name"));
            script.AppendLine(_width.ToJavascriptProperty("Width"));


            //script
            script.AppendJavascriptProperty(_cssClass, "CssClass");
            script.AppendJavascriptProperty(_tdClass, "TdClass");
            script.AppendJavascriptProperty(_cellCssClass, "CellCssClass");
            script.AppendJavascriptProperty(_headerAlign, "HeaderAlign");
            script.AppendJavascriptProperty(_cellAlign, "CellAlign");
            script.AppendJavascriptProperty(_isSortable, "Sort");
            script.AppendJavascriptProperty(_showCollapseExpandIcon, "ShowCollapseExpand");
            script.AppendJavascriptProperty(_allowTruncate, "AllowTruncate");
            script.AppendJavascriptProperty(_formatNumber, "FormatNumber");

            script.AppendJavascriptFunction(_customCellRender, "CustomCellRender");
            script.AppendJavascriptFunction(_customHeaderRender, "CustomHeaderRender");

            script.AppendLine("},");
            return script.ToString();
        }
    }
}
