namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;

    public static class FanexGridExtensions 
    {
        public static GridBuilder Tag(this HtmlHelper helper, string id)
        {
            return new GridBuilder(id);
        }
    }
}
