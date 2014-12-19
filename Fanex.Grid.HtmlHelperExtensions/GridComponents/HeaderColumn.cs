namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeaderColumn : RowColumn
    {
        public HeaderColumn(string name, string headerText) : base(name, null)
        {
            _headerText = headerText;
        }

        private string _headerText;
    }
}
