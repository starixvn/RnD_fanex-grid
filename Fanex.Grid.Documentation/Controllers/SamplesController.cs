using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fanex.Grid.Documentation.Models;

namespace Fanex.Grid.Documentation.Controllers
{
    public class SamplesController : Controller
    {
        private List<MenuItem> _sampleMenuList;
        public SamplesController()
        {
            _sampleMenuList = new List<MenuItem>
            {
                new MenuItem { Name = "Default Option", Url = "#",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Option 1", Url = "~/" },
                        new MenuItem { Name = "Default Option 2", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Customize Column", Url = "~/"},
                new MenuItem { Name = "Customize Row", Url = "~/"},
                new MenuItem { Name = "Customize Cell", Url = "~/"},
                new MenuItem { Name = "Header Grouping", Url = "~/"},
                new MenuItem { Name = "Grid Title", Url = "~/"},
                new MenuItem { Name = "Footer", Url = "~/"},
                new MenuItem { Name = "Sorting", Url = "~/"},
                new MenuItem { Name = "Custom Sorting", Url = "~/"},
                new MenuItem { Name = "Pager", Url = "~/"},
                new MenuItem { Name = "Custom Pager", Url = "~/"},
                new MenuItem { Name = "Custom Footer Pager", Url = "~/"},
                new MenuItem { Name = "Frozen Columns", Url = "~/"},
                new MenuItem { Name = "Show/Hide Columns", Url = "~/"},
                new MenuItem { Name = "Merging", Url = "~/"},
                new MenuItem { Name = "Custom Cell", Url = "~/"},
                new MenuItem { Name = "Tree Grid", Url = "~/"},
                new MenuItem { Name = "Auto Truncate", Url = "~/"},
                new MenuItem { Name = "5000 Rows", Url = "~/"},
                new MenuItem { Name = "Append Body Rows", Url = "~/"},
                new MenuItem { Name = "Multiple Language", Url = "~/"},
                new MenuItem { Name = "Auto Resize Columns", Url = "~/"},
                new MenuItem { Name = "Auto Resize Full Width", Url = "~/"},
                new MenuItem { Name = "1000 Rows 100 Cols", Url = "~/"},
                new MenuItem { Name = "Render Multiple", Url = "~/"},
                new MenuItem { Name = "Virtual Rendering", Url = "~/"}
            };
        }
        // GET: Samples
        public ActionResult Index(string viewName = "")
        {
            if (string.IsNullOrEmpty(viewName))
            {
                viewName = "DefaultOption";
            }
            ViewBag.MenuList = _sampleMenuList;
            return View(string.Format("~/Views/Samples/{0}.cshtml", viewName));
        }
    }
}