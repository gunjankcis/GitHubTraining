﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            //ViewBag.SuccessMessage = "This is a login Screen";
            ViewBag.SuccessMessage = "Manoj Changed the Message";
            ViewBag.testMessage = "This is a test message.";
            return View();
        }
    }
}
