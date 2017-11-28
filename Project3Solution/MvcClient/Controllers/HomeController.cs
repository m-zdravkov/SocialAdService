﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcClient.Helpers;
using MvcClient.AuthService;

namespace MvcClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ads = ServiceHelper.GetAuthServiceClient().GetAds(0,64).ToList<Ad>();
            return View(ads);
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