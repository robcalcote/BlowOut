using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        public string sName = null;
        public string sEmail = null;

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            this.sName = name;
            this.sEmail = email;

            ViewBag.vbName = sName + ".";
            ViewBag.vbEmail = sEmail;

            return View();
        }
    }
}