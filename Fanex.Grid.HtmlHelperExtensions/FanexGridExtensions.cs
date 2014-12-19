namespace Fanex.Grid.HtmlHelperExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;

    public static class FanexGridExtensions 
    {
        public static Grid FanexGrid(this HtmlHelper helper, string id)
        {
            return new Grid(id);
        }
    }
}
