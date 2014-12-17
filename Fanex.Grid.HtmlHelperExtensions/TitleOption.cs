namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

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

        private string _text = string.Empty;

        private bool _hideWhenNoData = true;

        private bool _showExcelButton;

        private string _exportExcelFunction = string.Empty;

        private bool _showBackButton;

        private string _backFunction = string.Empty;

        private bool _showSendMailButton;

        private string _sendMailFunction = string.Empty;

        private bool _showCollapseExpandButton;

        private string _customButtons = string.Empty;

        private bool _showButtonsWhenNoData;

        public TitleOption SetVisibleWhenNoData()
        {
            _hideWhenNoData = false;
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

    }
}
