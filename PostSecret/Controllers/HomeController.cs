using Netfinity;
using PostSecret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostSecret.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dm = new DataManager();
            var vault = dm.GetVault();
            return View(vault);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}