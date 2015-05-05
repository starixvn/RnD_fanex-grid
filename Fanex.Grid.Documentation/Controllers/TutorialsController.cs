using Fanex.Grid.Documentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fanex.Grid.Documentation.Controllers
{
    public class TutorialsController : Controller
    {
        private List<MenuItem> _tutorialsMenuList;

        public TutorialsController()
        {
            _tutorialsMenuList = new List<MenuItem>
            {
                new MenuItem { Name = "Part 1", Url = "~/"},
                new MenuItem { Name = "Part 2", Url = "~/"},
                new MenuItem { Name = "Part 3", Url = "~/"},
                new MenuItem { Name = "Part 4", Url = "~/"},
                new MenuItem { Name = "Part 5", Url = "~/"},
                new MenuItem { Name = "Part 6", Url = "~/"},
                new MenuItem { Name = "Part 7", Url = "~/"},
                new MenuItem { Name = "Part 8", Url = "~/"},
                new MenuItem { Name = "Part 9", Url = "~/"},
                new MenuItem { Name = "Part 10", Url = "~/"},
                new MenuItem { Name = "Part 11", Url = "~/"}
            };
        }

        // GET: Tutorials
        public ActionResult Index(string viewName = "")
        {
            if (string.IsNullOrEmpty(viewName))
            {
                viewName = "Part1";
            }
            ViewBag.MenuList = _tutorialsMenuList;
            return View(string.Format("~/Views/Tutorials/{0}.cshtml", viewName));
        }
    }
}