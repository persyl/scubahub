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
            var context =  new entity_demo_dbEntities();
            var diver = new Divers
            {
                Name = "A new diver",
                Date = DateTime.Now
            };
            context.Divers.Add(diver);
            context.SaveChanges();

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