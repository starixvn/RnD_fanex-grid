namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;

    public class TitleOption
    {
        //    text: "",
        //    hideWhenNoData: true,
        //    showExcelButton: false,
        //    exportExcelFunction: null,
        //    showBackButton: false,
        //    backFunction: null,
        //    showSendMailButton: false,
        //    sendMailFunction: null,
        //    showCollapseExpandButton: false,
        //    customButtons: '',
        //    showButtonsWhenNoData: false

        public TitleOption(string text)
        {
            _text = text;
        }

        private string _text;

        private bool? _showExcelButton;

        private string _exportExcelFunction;

        private bool? _showBackButton;

        private string _backFunction;

        private bool? _showSendMailButton;

        private string _sendMailFunction;

        private bool? _showCollapseExpandButton;

        private string _customButtonsHtml;

        private bool? _showButtonsWhenNoData;

        public TitleOption SetButtonsVisibleWhenNoData()
        {
            _showButtonsWhenNoData = true;
            return this;
        }

        public TitleOption SetExportExcelButton(string exportExcelFunction)
        {
            _showExcelButton = true;
            _exportExcelFunction = exportExcelFunction;
            return this;
        }

        public TitleOption SetBackButton(string backFunction)
        {
            _showBackButton = true;
            _backFunction = backFunction;

            return this;
        }

        public TitleOption SetSendMailButton(string sendMailFunction)
        {
            _showSendMailButton = true;
            _sendMailFunction = sendMailFunction;
            return this;
        }

        public TitleOption SetCollapseExpandButtonVisible()
        {
            _showCollapseExpandButton = true;
            return this;
        }

        public TitleOption SetCustomButtons(string customButtonsHtml)
        {
            _customButtonsHtml = customButtonsHtml;

            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptProperty(_text, "text");
            script.AppendJavascriptProperty(_showExcelButton, "showExcelButton");
            script.AppendJavascriptFunction(_exportExcelFunction, "exportExcelFunction");
            script.AppendJavascriptProperty(_showBackButton, "showBackButton");
            script.AppendJavascriptFunction(_backFunction, "backFunction");
            script.AppendJavascriptProperty(_showSendMailButton, "showSendMailButton");
            script.AppendJavascriptFunction(_sendMailFunction, "sendMailFunction");
            script.AppendJavascriptProperty(_showCollapseExpandButton, "showCollapseExpandButton");
            script.AppendJavascriptProperty(_customButtonsHtml, "customButtons");
            script.AppendJavascriptProperty(_showButtonsWhenNoData, "showButtonsWhenNoData");

            script.AppendLine("}");

            return script.ToString();
        }
    }
}
