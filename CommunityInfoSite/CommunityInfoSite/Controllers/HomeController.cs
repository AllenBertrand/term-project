﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityInfoSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "This site is dedicated to discussing and learning about gardening!";
            ViewBag.Message = "More to come in the future :)";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Title = "Future home of the Contact page";
        //    ViewBag.Message = "A brief history of the community...";

        //    return View();
        //}

        //public ActionResult History()
        //{
        //    ViewBag.Title = "History";
        //    ViewBag.Message = "A brief history of the community";

        //    return View();
        //}
    }
}