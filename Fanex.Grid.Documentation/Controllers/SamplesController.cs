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
                new MenuItem { Name = "Default Options", Url = "#", ViewName = "DefaultOptions",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Body Rows", Url = "~/Samples/Index" , ViewName = "BodyRows"},
                        new MenuItem { Name = "Default Option 2", Url = "~/Samples/Index" , ViewName = "DefaultOptions"}
                    }
                },
                new MenuItem { Name = "Customized Options", Url = "#", ViewName = "CustomizedOptions",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Frozen Columns", Url = "~/Samples/Index" , ViewName = "FrozenColumns"},
                        new MenuItem { Name = "Multiple Languages", Url = "~/Samples/Index", ViewName = "MultipleLanguages"},
                        new MenuItem { Name = "Custom Height", Url = "~/Samples/Index", ViewName = "CustomHeight"},
                        new MenuItem { Name = "Distinct Rows", Url = "~/Samples/Index", ViewName = "DistinctRows"},
                        new MenuItem { Name = "Highlight Rows", Url = "~/Samples/Index", ViewName = "HighlightRows"},
                        new MenuItem { Name = "Show Number Column", Url = "~/Samples/Index", ViewName = "ShowNumberColumn"},
                        new MenuItem { Name = "Margin Right", Url = "~/Samples/Index", ViewName = "MarginRight"},
                        new MenuItem { Name = "Hide Background Scroller", Url = "~/Samples/Index", ViewName = "HideBackgroundScroller"},
                        new MenuItem { Name = "Fixed Width/Height", Url = "~/Samples/Index", ViewName = "FixedWidthHeight"},
                        new MenuItem { Name = "Min Width/Height", Url = "~/Samples/Index", ViewName = "MinWidthHeight"},
                        new MenuItem { Name = "Scroller Width", Url = "~/Samples/Index", ViewName = "ScrollerWidth"}
                    }
                },
                new MenuItem { Name = "Customized Content", ViewName = "CustomizedContent", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Customized Column", Url = "~/Samples/Index" , ViewName = "CustomizedColumn"},
                        new MenuItem { Name = "Customized Row", Url = "~/Samples/Index" , ViewName = "CustomizedRow"},
                        new MenuItem { Name = "Customized Cell", Url = "~/Samples/Index" , ViewName = "CustomizedCell"},
                        new MenuItem { Name = "Append Rows Realtime", Url = "~/Samples/Index" , ViewName = "AppendRowsRealtime"}
                    }
                },
                new MenuItem { Name = "Header", ViewName = "Header", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = "~/Samples/Index" , ViewName = "Grouping"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/Index" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Title", ViewName = "Title", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Title Text", Url = "~/Samples/Index" , ViewName = "TitleText"},
                        new MenuItem { Name = "Suppotted Buttons", Url = "~/Samples/Index" , ViewName = "SuppottedButtons"},
                        new MenuItem { Name = "Customized Buttons", Url = "~/Samples/Index" , ViewName = "CustomizedButtons"}
                    }
                },
                new MenuItem { Name = "Footer", ViewName = "Footer", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = "~/Samples/Index" , ViewName = "Grouping"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/Index" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Sort", ViewName = "Sort", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Client Side", Url = "~/Samples/Index" , ViewName = "DefaultClientSide"},
                        new MenuItem { Name = "Customized Client Side", Url = "~/Samples/Index" , ViewName = "CustomizedClientSide"},
                        new MenuItem { Name = "Server Side", Url = "~/Samples/Index" , ViewName = "ServerSide"},
                        new MenuItem { Name = "Initial Sort Icon", Url = "~/Samples/Index" , ViewName = "InitialSortIcon"}
                    }
                },
                new MenuItem { Name = "Pager", ViewName = "Pager", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Pager", Url = "~/Samples/Index" , ViewName = "DefaultPager"},
                        new MenuItem { Name = "Pager With Footer", Url = "~/Samples/Index" , ViewName = "PagerWithFooter"},
                        new MenuItem { Name = "Server Side Pager", Url = "~/Samples/Index" , ViewName = "ServerSidePager"},
                        new MenuItem { Name = "Pager Events", Url = "~/Samples/Index" , ViewName = "PagerEvents"}
                    }
                },
                
                new MenuItem { Name = "Show/Hide Columns", ViewName = "ShowHideColumns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Render", Url = "~/Samples/Index" , ViewName = "DefaultRender"},
                        new MenuItem { Name = "Real time Show/Hide", Url = "~/Samples/Index" , ViewName = "RealtimeShowHide"}
                    }
                },
                new MenuItem { Name = "Merging", ViewName = "Merging",  
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Columns", Url = "~/Samples/Index" , ViewName = "Columns"},
                        new MenuItem { Name = "Rows", Url = "~/Samples/Index" , ViewName = "Rows"},
                        new MenuItem { Name = "Both Columns and Rows", Url = "~/Samples/Index" , ViewName = "BothColumnsAndRows"},
                        new MenuItem { Name = "Highlight Frozen Width", Url = "~/Samples/Index" , ViewName = "HighlightFrozenWidth"},
                        new MenuItem { Name = "Correct Rows Height", Url = "~/Samples/Index" , ViewName = "CorrectRowsHeight"},
                    }
                },
                new MenuItem { Name = "Tree", ViewName = "Tree", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/Index" , ViewName = "Default"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/Index" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Text Truncate", Url = "~/Samples/Index", ViewName = "TextTruncate"},
                new MenuItem { Name = "Formatters", ViewName = "Formatters", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Date Time", Url = "~/Samples/Index", ViewName = "DateTime" },
                        new MenuItem { Name = "Number", Url = "~/Samples/Index", ViewName = "Number" }
                    }
                },
                new MenuItem { Name = "Auto Resize Columns", ViewName = "AutoResizeColumns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/Index", ViewName = "Default" },
                        new MenuItem { Name = "Full Width", Url = "~/Samples/Index", ViewName = "FullWidth" }
                    }
                },
                new MenuItem { Name = "Render Multiple Grids", Url = "~/Samples/Index", ViewName = "RenderMultipleGrids"},
                new MenuItem { Name = "Virtual Rendering", ViewName = "VirtualRendering", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/Index" , ViewName = "Default"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/Index" , ViewName = "Customized"}
                    }
                }
            };
        }
        // GET: Samples
        public ActionResult Index()
        {
            ViewBag.MenuList = _sampleMenuList;
            return View();
        }

        public ActionResult SamplePage(string sampleName)
        {
            return View(string.Format("~/Views/Samples/{0}.cshtml", sampleName));
        }
    }
}