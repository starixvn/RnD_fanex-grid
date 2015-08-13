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
        private static List<MenuItem> _sampleMenuList = new List<MenuItem>
            {
                new MenuItem { Name = "Default Options", Url = "~/Samples/SamplePage?sampleName=", ViewName = "DefaultOption" },
                new MenuItem { Name = "Customized Options", ViewName = "CustomizedOptions",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Frozen Columns", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "FrozenColumns"},
                        new MenuItem { Name = "Multiple Languages", Url = "~/Samples/SamplePage?sampleName=", ViewName = "MultipleLanguages"},
                        new MenuItem { Name = "Custom Height", Url = "~/Samples/SamplePage?sampleName=", ViewName = "CustomHeight"},
                        new MenuItem { Name = "Distinct Rows", Url = "~/Samples/SamplePage?sampleName=", ViewName = "DistinctRows"},
                        new MenuItem { Name = "Highlight Rows", Url = "~/Samples/SamplePage?sampleName=", ViewName = "HighlightRows"},
                        new MenuItem { Name = "Show Number Column", Url = "~/Samples/SamplePage?sampleName=", ViewName = "ShowNumberColumn"},
                        new MenuItem { Name = "Margin Right", Url = "~/Samples/SamplePage?sampleName=", ViewName = "MarginRight"},
                        new MenuItem { Name = "Hide Background Scroller", Url = "~/Samples/SamplePage?sampleName=", ViewName = "HideBackgroundScroller"},
                        new MenuItem { Name = "Fixed Width/Height", Url = "~/Samples/SamplePage?sampleName=", ViewName = "FixedWidthHeight"},
                        new MenuItem { Name = "Min Width/Height", Url = "~/Samples/SamplePage?sampleName=", ViewName = "MinWidthHeight"},
                        new MenuItem { Name = "Scroller Width", Url = "~/Samples/SamplePage?sampleName=", ViewName = "ScrollerWidth"}
                    }
                },
                new MenuItem { Name = "Customized Content", ViewName = "CustomizedContent", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Customized Column", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CustomizedColumn"},
                        new MenuItem { Name = "Customized Row", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CustomizedRow"},
                        new MenuItem { Name = "Customized Cell", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CustomizedCell"},
                        new MenuItem { Name = "Append Rows Realtime", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "AppendRowsRealtime"}
                    }
                },
                new MenuItem { Name = "Header", ViewName = "Header", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Grouping"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Title", ViewName = "Title", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Title Text", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "TitleText"},
                        new MenuItem { Name = "Suppotted Buttons", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "SuppottedButtons"},
                        new MenuItem { Name = "Customized Buttons", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CustomizedButtons"}
                    }
                },
                new MenuItem { Name = "Footer", ViewName = "Footer", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Grouping"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Sort", ViewName = "Sort", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Client Side", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "DefaultClientSide"},
                        new MenuItem { Name = "Customized Client Side", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CustomizedClientSide"},
                        new MenuItem { Name = "Server Side", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "ServerSide"},
                        new MenuItem { Name = "Initial Sort Icon", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "InitialSortIcon"}
                    }
                },
                new MenuItem { Name = "Pager", ViewName = "Pager", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Pager", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "DefaultPager"},
                        new MenuItem { Name = "Pager With Footer", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "PagerWithFooter"},
                        new MenuItem { Name = "Server Side Pager", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "ServerSidePager"},
                        new MenuItem { Name = "Pager Events", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "PagerEvents"}
                    }
                },
                
                new MenuItem { Name = "Show/Hide Columns", ViewName = "ShowHideColumns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Render", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "DefaultRender"},
                        new MenuItem { Name = "Real time Show/Hide", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "RealtimeShowHide"}
                    }
                },
                new MenuItem { Name = "Merging", ViewName = "Merging",  
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Columns", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Columns"},
                        new MenuItem { Name = "Rows", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Rows"},
                        new MenuItem { Name = "Both Columns and Rows", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "BothColumnsAndRows"},
                        new MenuItem { Name = "Highlight Frozen Width", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "HighlightFrozenWidth"},
                        new MenuItem { Name = "Correct Rows Height", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "CorrectRowsHeight"},
                    }
                },
                new MenuItem { Name = "Tree", ViewName = "Tree", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Default"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Customized"}
                    }
                },
                new MenuItem { Name = "Text Truncate", Url = "~/Samples/SamplePage?sampleName=", ViewName = "TextTruncate"},
                new MenuItem { Name = "Formatters", ViewName = "Formatters", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Date Time", Url = "~/Samples/SamplePage?sampleName=", ViewName = "DateTime" },
                        new MenuItem { Name = "Number", Url = "~/Samples/SamplePage?sampleName=", ViewName = "Number" }
                    }
                },
                new MenuItem { Name = "Auto Resize Columns", ViewName = "AutoResizeColumns", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/SamplePage?sampleName=", ViewName = "Default" },
                        new MenuItem { Name = "Full Width", Url = "~/Samples/SamplePage?sampleName=", ViewName = "FullWidth" }
                    }
                },
                new MenuItem { Name = "Render Multiple Grids", Url = "~/Samples/SamplePage?sampleName=", ViewName = "RenderMultipleGrids"},
                new MenuItem { Name = "Virtual Rendering", ViewName = "VirtualRendering", 
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Default"},
                        new MenuItem { Name = "Customized", Url = "~/Samples/SamplePage?sampleName=" , ViewName = "Customized"}
                    }
                }
            };

        public SamplesController()
        {
            ViewBag.TabName = "samples";
            ViewBag.IsShowInIframe = true;
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