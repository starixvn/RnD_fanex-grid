using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fanex.Grid.Documentation.Models
{
    public class MenuItem
    {
        public string Name { get; set; }

        public bool IsSelected { get; set; }

        public string Url { get; set; }

        public List<MenuItem> SubMenus { get; set; }
    }
}