using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please contact us by one of the following methods.";
            ViewBag.VoiceMail = "If we don't answer the phone, leave a brief message and we'll get back to you as soon as we can.";
            ViewBag.Email = "If you send us an email, we promise to get back to you no later than 2 business days.";

            return View();
        }
    }
}