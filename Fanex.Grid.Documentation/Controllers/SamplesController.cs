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
                new MenuItem { Name = "Default Options", Url = "#",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Body Rows", Url = "~/" },
                        new MenuItem { Name = "Default Option 2", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Customized Options", Url = "#",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Frozen Columns", Url = "~/" },
                        new MenuItem { Name = "Multiple Languages", Url = "~/"},
                        new MenuItem { Name = "Custom Height", Url = "~/"},
                        new MenuItem { Name = "Distinct Rows", Url = "~/"},
                        new MenuItem { Name = "Highlight Rows", Url = "~/"},
                        new MenuItem { Name = "Show Number Column", Url = "~/"},
                        new MenuItem { Name = "Margin Right", Url = "~/"},
                        new MenuItem { Name = "Hide Background Scroller", Url = "~/"},
                        new MenuItem { Name = "Fixed Width/Height", Url = "~/"},
                        new MenuItem { Name = "Min Width/Height", Url = "~/"},
                        new MenuItem { Name = "Scroller width", Url = "~/"}
                    }
                },
                new MenuItem { Name = "Customized Content", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Customized Column", Url = "~/" },
                        new MenuItem { Name = "Customized Row", Url = "~/" },
                        new MenuItem { Name = "Customized Cell", Url = "~/" },
                        new MenuItem { Name = "Append Rows Realtime", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Header", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = "~/" },
                        new MenuItem { Name = "Customized", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Title", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Title Text", Url = "~/" },
                        new MenuItem { Name = "Suppotted Buttons", Url = "~/" },
                        new MenuItem { Name = "Customized Buttons", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Footer", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Title Text", Url = "~/" },
                        new MenuItem { Name = "Suppotted Buttons", Url = "~/" },
                        new MenuItem { Name = "Customized Buttons", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Sort", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Client Side", Url = "~/" },
                        new MenuItem { Name = "Customized Client Side", Url = "~/" },
                        new MenuItem { Name = "Server Side", Url = "~/" },
                        new MenuItem { Name = "Initial Sort Icon", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Pager", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Pager", Url = "~/" },
                        new MenuItem { Name = "Pager With Footer", Url = "~/" },
                        new MenuItem { Name = "Server Side Pager", Url = "~/" },
                        new MenuItem { Name = "Pager Events", Url = "~/" }
                    }
                },
                
                new MenuItem { Name = "Show/Hide Columns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Render", Url = "~/" },
                        new MenuItem { Name = "Real time Show/Hide", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Merging", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Columns", Url = "~/" },
                        new MenuItem { Name = "Rows", Url = "~/" },
                        new MenuItem { Name = "Both Columns and Rows", Url = "~/" },
                        new MenuItem { Name = "Highlight Frozen Width", Url = "~/" },
                        new MenuItem { Name = "Correct Rows Height", Url = "~/" },
                    }
                },
                new MenuItem { Name = "Tree", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/" },
                        new MenuItem { Name = "Customized", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Text Truncate", Url = "~/"},
                new MenuItem { Name = "Formatters", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Date Time", Url = "~/" },
                        new MenuItem { Name = "Number", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Auto Resize Columns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/" },
                        new MenuItem { Name = "Full width", Url = "~/" }
                    }
                },
                new MenuItem { Name = "Render Multiple Grids", Url = "~/"},
                new MenuItem { Name = "Virtual Rendering", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/" },
                        new MenuItem { Name = "Customized", Url = "~/" }
                    }
                }
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