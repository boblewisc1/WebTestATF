﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
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


        public ActionResult GetStart()
        {
            return View();
        }

        public ActionResult GetStart1()
        {
            return View();
        }

        public ActionResult GetStart2()
        {
            return View();
        }

        public ActionResult GetStart3()
        {
            return View();
        }


        public ActionResult GetHtml()
        {
            return View();
        }

    }
}