using MvcClient.Models;
using MvcClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel lvm)
        {

            bool canLogIn = false;
            using (var authsvc = ServiceHelper.GetPublicServiceClient())
            {
                try
                {
                    canLogIn = authsvc.Login(lvm.Email, lvm.Password);
                }
                catch (Exception)
                {
                    ViewBag.StatusMessage = "Could not log in with the given credentials";
                    return View();
                }
            }

            if (!canLogIn)
            {
                ViewBag.StatusMessage = "Could not log in with the given credentials";
                return View();
            }
            else
            {
                AuthHelper.LogIn(lvm);
                AuthHelper.UpdateLogInDetails();
                return RedirectToAction("Index","Home");
            }
        }

        public ActionResult LogOut()
        {
            AuthHelper.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}