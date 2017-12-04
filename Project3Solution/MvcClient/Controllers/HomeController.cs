using System;
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
                var list = ServiceHelper.GetAuthServiceClient().GetAds(0, 64).ToList<Ad>();
                return View(list);
            }
            else return View(ads);
        }

        public ActionResult AdType(string type)
        {
            AdType adType;

            switch(type)
            {
                case "selling": adType = AuthService.AdType.Selling; break;
                case "buying": adType = AuthService.AdType.Buying; break;
                case "offer": adType = AuthService.AdType.ServiceOffer; break;
                case "request": adType = AuthService.AdType.ServiceRequest; break;
                case "event": adType = AuthService.AdType.Event; break;
                case "other": adType = AuthService.AdType.Other; break;
                default: adType = AuthService.AdType.All; break;
            }

            var list = ServiceHelper.GetAuthServiceClient().FindAds(0, 100, "", "", adType).ToList<Ad>();
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