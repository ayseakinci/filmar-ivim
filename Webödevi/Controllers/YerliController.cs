using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webödevi.Controllers
{
    public class yerliController : Controller
    {
        public ActionResult yerlifilmler()
        {


            return View();
        }
        public ActionResult page2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult page3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult page4()
        {
            return View();
        }

        public ActionResult page5()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}