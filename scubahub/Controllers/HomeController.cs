using ScubahubDataLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scubahub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dbService = new Service();
            dbService.AddDiver("One new diver");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The one and only hub for diver!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "More contact details will come later";

            return View();
        }
    }
}