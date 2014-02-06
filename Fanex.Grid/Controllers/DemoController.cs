// --------------------------------------------------------------------------
// <copyright file="DemoController.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------
// <history>
//   <change who="Ricky.Nguyen" date="2013.11.27">Created</change>
// </history>

namespace Fanex.Grid.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Demo controller.
    /// </summary>
    public class DemoController : Controller
    {
        ////
        //// GET: /Demo/

        public ActionResult Index()
        {
            ViewBag.IsShowDemo = true;
            return View();
        }

        public ActionResult Api()
        {
            ViewBag.IsShowDemo = true;
            return View();
        }

        public ActionResult DefaultFunctionality()
        {
            return View();
        }

        public ActionResult Sorting()
        {
            return View();
        }

        public ActionResult CustomSorting()
        {
            return View();
        }

        public ActionResult HeaderGrouping()
        {
            return View();
        }

        public ActionResult Pager()
        {
            return View();
        }

        public ActionResult CustomPager()
        {
            return View();
        }

        public ActionResult TreeGrid()
        {
            return View();
        }

        public ActionResult Merging()
        {
            return View();
        }

        public ActionResult FrozenColumns()
        {
            return View();
        }

        public ActionResult GridTitle()
        {
            return View();
        }

        public ActionResult Footer()
        {
            return View();
        }

        public ActionResult FormatNumber()
        {
            return View();
        }

        public ActionResult CustomCell()
        {
            return View();
        }

        public ActionResult CustomOption()
        {
            return View();
        }

        public ActionResult ShowHideColumns()
        {
            return View();
        }

        public ActionResult AutoTruncate()
        {
            return View();
        }

        public ActionResult Demo5000Rows()
        {
            return View();
        }

        public ActionResult AppendBodyRows()
        {
            return View();
        }

        public ActionResult Popup()
        {
            return View();
        }

        public ActionResult MultipleLanguage()
        {
            return View();
        }

        public ActionResult AutoResizeColumns()
        {
            return View();
        }

        public ActionResult Demo1000Rows100Cols()
        {
            return View();
        }

        public ActionResult CustomFooterPager()
        {
            return View();
        }
    }
}