using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcClient.AuthService;
using MvcClient.Models;
using MvcClient.Helpers;

namespace MvcClient.Controllers
{
    public class PostController : Controller
    {
        public ActionResult Ad()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ad(PostAdViewModel ad)
        {
            try
            {
                ServiceHelper.GetServiceClientLoggedIn().PostAd(ad.Title, ad.Content, ad.Location, ad.Type);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage += ex.Message;
                return View();
            }
            return RedirectToAction("Index","Home");
        }

        public ActionResult Reserve(string id)
        {
            try
            {
                ServiceHelper.GetServiceClientLoggedIn().ReserveAd(id);
                ViewBag.SuccessMessage = "Ad reserved successfully.";
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage += ex.Message;
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Page(string id)
        {
            var client = ServiceHelper.GetAuthServiceClient();
            throw new NotImplementedException("Not implemented yet!");

            return View();
        }
    }
}