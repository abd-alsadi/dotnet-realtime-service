using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KmnlkRealTimeApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Kmnlk Real Time Api";

            return View();
        }
        public ActionResult Test()
        {
            ViewBag.Title = "Kmnlk Real Time Api";

            return View();
        }
    }
}
