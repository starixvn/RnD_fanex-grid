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

        private string _customButtons;

        private bool? _showButtonsWhenNoData;

        public TitleOption SetButtonsVisibleWhenNoData()
        {
            _showButtonsWhenNoData = true;
            return this;
        }

        public TitleOption SetExcelButtonVisible()
        {
            _showExcelButton = true;
            return this;
        }

        public TitleOption SetExportExcelFunction(string exportExcelFunction)
        {
            _exportExcelFunction = exportExcelFunction;
            return this;
        }

        public TitleOption SetBackButtonVisible()
        {
            _showBackButton = true;

            return this;
        }

        public TitleOption SetBackFunction(string backFunction)
        {
            _backFunction = backFunction;

            return this;
        }

        public override string ToString()
        {
            var script = new StringBuilder();

            script.AppendLine("{");

            script.AppendJavascriptPropertyLine(_text, "text");
            script.AppendJavascriptPropertyLine(_showExcelButton, "showExcelButton");
            script.AppendJavascriptPropertyLine(_exportExcelFunction, "exportExcelFunction");
            script.AppendJavascriptPropertyLine(_showBackButton, "showBackButton");
            script.AppendJavascriptPropertyLine(_backFunction, "backFunction");
            script.AppendJavascriptPropertyLine(_showSendMailButton, "showSendMailButton");
            script.AppendJavascriptPropertyLine(_sendMailFunction, "sendMailFunction");
            script.AppendJavascriptPropertyLine(_showCollapseExpandButton, "showCollapseExpandButton");
            script.AppendJavascriptPropertyLine(_customButtons, "customButtons");
            script.AppendJavascriptPropertyLine(_showButtonsWhenNoData, "showButtonsWhenNoData");

            script.AppendLine("}");

            return script.ToString();
        }
    }
}
