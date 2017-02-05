using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCOrnek1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DateTime zaman = DateTime.Now;
            ViewBag.AnlikZaman = zaman; //istedigimiz turde degiskeni atamamizi saglar.

            return View();
        }
    }
}