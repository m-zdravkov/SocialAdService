using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcClient.Helpers;
using MvcClient.SasPublic;

namespace MvcClient.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            var ads = ServiceHelper.GetAuthServiceClient().GetAds(0,64).ToList<Ad>();
            return View(ads);
        }*/

        public ActionResult Index()
        {
            IList<Ad> ads = null;
            if (TempData["ads"] != null)
                ads = (IList < Ad > )TempData["ads"];

            if (ads == null)
            {
                var list = ServiceHelper.GetPublicServiceClient().GetAds(0, 64).ToList<Ad>();
                return View(list);
            }
            else return View(ads);
        }

        public ActionResult AdType(string type)
        {
            AdType adType;

            switch(type)
            {
                case "selling": adType = SasPublic.AdType.Selling; break;
                case "buying": adType = SasPublic.AdType.Buying; break;
                case "offer": adType = SasPublic.AdType.ServiceOffer; break;
                case "request": adType = SasPublic.AdType.ServiceRequest; break;
                case "event": adType = SasPublic.AdType.Event; break;
                case "other": adType = SasPublic.AdType.Other; break;
                default: adType = SasPublic.AdType.All; break;
            }

            var list = ServiceHelper.GetPublicServiceClient().FindAds(0, 100, "", "", adType).ToList<Ad>();
            TempData["ads"] = list;

            return RedirectToAction("Index");
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