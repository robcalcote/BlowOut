﻿using System;
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
            ViewBag.Rentals = "We offer only the highest quality rentals, both new and used are typically available. Please see look below for a list of the instruments that we rent.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Learn more about our company below!";

            return View();
        }

        // Contact ActionMethod to return Contact page
        public ActionResult Contact()
        {
            // These messages are passed to the contact page through different ViewBags
            ViewBag.Message = "Please contact us by one of the following methods.";
            ViewBag.VoiceMail = "If we don't answer the phone, leave a brief message and we'll get back to you as soon as we can.";
            ViewBag.Email = "If you send us an email, we promise to get back to you no later than 2 business days.";

            // View for contact page is returned
            return View();
        }

        //THE ACTION METHODS BELOW RETURN INSTRUMENTS VIEWS BASED ON THE NAME OF THE ACTION METHOD
        //TRUMPET
        public ActionResult Trumpet()
        {
            return View();
        }
        public ActionResult TrumpetNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$55 a month";
            return View("Trumpet");
        }
        public ActionResult TrumpetUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$25 a month";
            return View("Trumpet");
        }

        //TROMBONE
        public ActionResult Trombone()
        {
            return View();
        }
        public ActionResult TromboneNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$60 a month";
            return View("Trombone");
        }
        public ActionResult TromboneUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$35 a month";
            return View("Trombone");
        }

        //TUBA
        public ActionResult Tuba()
        {
            return View();
        }
        public ActionResult TubaNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$70 a month";
            return View("Tuba");
        }
        public ActionResult TubaUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$50 a month";
            return View("Tuba");
        }

        //FLUTE
        public ActionResult Flute()
        {
            return View();
        }
        public ActionResult FluteNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$40 a month";
            return View("Flute");
        }
        public ActionResult FluteUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$25 a month";
            return View("Flute");
        }

        //CLARINET
        public ActionResult Clarinet()
        {
            return View();
        }
        public ActionResult ClarinetNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$35 a month";
            return View("Clarinet");
        }
        public ActionResult ClarinetUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$27 a month";
            return View("Clarinet");
        }

        //SAXOPHONE
        public ActionResult Saxophone()
        {
            return View();
        }
        public ActionResult SaxophoneNew()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$42 a month";
            return View("Saxophone");
        }
        public ActionResult SaxophoneUsed()
        {
            ViewBag.Notice = "***Please keep in mind that once the 18 months of rental history has been reached, you will own the instrument." +
            " If you return it at any time within the first three months, there will be a $200 re-stocking fee." +
            " If you return it after three months, you forfeit any equity in the instrument.";
            ViewBag.Rates = "$30 a month";
            return View("Saxophone");
        }
    }
}