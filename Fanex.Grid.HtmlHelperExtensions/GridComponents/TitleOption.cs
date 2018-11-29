namespace Fanex.Grid.HtmlHelperExtensions
{
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Extensions;
    using Newtonsoft.Json;

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
            Text = text;
        }

        public string Text { get; private set; }

        public bool? ShowExcelButton { get; private set; }

        public string ExportExcelFunction { get; private set; }

        public bool? ShowBackButton { get; private set; }

        public string BackFunction { get; private set; }

        public bool? ShowSendMailButton { get; private set; }

        public string SendMailFunction { get; private set; }

        public bool? ShowCollapseExpandButton { get; private set; }

        [JsonProperty(PropertyName = "customButtons")]
        public string CustomButtonsHtml { get; private set; }

        public bool? ShowButtonsWhenNoData { get; private set; }

        public TitleOption SetButtonsVisibleWhenNoData()
        {
            ShowButtonsWhenNoData = true;
            return this;
        }

        public TitleOption SetExportExcelButton(string exportExcelFunction)
        {
            ShowExcelButton = true;
            ExportExcelFunction = exportExcelFunction;
            return this;
        }

        public TitleOption SetBackButton(string backFunction)
        {
            ShowBackButton = true;
            BackFunction = backFunction;

            return this;
        }

        public TitleOption SetSendMailButton(string sendMailFunction)
        {
            ShowSendMailButton = true;
            SendMailFunction = sendMailFunction;
            return this;
        }

        public TitleOption SetCollapseExpandButtonVisible()
        {
            ShowCollapseExpandButton = true;
            return this;
        }

        public TitleOption SetCustomButtons(string customButtonsHtml)
        {
            CustomButtonsHtml = customButtonsHtml;

            return this;
        }
    }
}