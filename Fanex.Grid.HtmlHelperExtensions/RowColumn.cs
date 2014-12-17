namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
using Fanex.Grid.HtmlHelperExtensions.Enumerations;

    public class RowColumn
    {
        private string _name = string.Empty;

        private object _value;

        private int _mergeRowNumber;

        private int _mergeColNumner;

        private string _customCellRender;

        private string _tdClass = string.Empty;

        private string _cssClass = string.Empty;

        private TextAlign _cellAlign = TextAlign.Left;

        private string _customAttributes = string.Empty;

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
    }
}
