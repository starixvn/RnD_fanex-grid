using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fanex.Grid.Documentation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.TabName = "introduction";

            return View();
        }

        public ActionResult ApiReferences()
        {
            ViewBag.TabName = "api";

            return View();
        }
    }
}