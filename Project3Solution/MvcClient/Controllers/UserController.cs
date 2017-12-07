using MvcClient.Helpers;
using MvcClient.Models;
using MvcClient.SocialAdService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var client = ServiceHelper.GetServiceClientLoggedIn();
            var reserved = client.GetReservedAds();
            var posted = client.GetPostedAds();
            TempData["reservedAds"] = reserved;
            TempData["postedAds"] = posted;

            return View(client.GetCurrentUser());
        }

        [HttpPost]
        public ActionResult Index(string buttonValue)
        {
            var client = ServiceHelper.GetServiceClientLoggedIn();

            switch(buttonValue)
            {
                case "Buy Reservations":
                    client.BuyReservations();
                    break;
                case "Buy Boosts":
                    client.BuyBoosts();
                    break;
                default: break;
            }

            return View(client.GetCurrentUser());
        }

        public ActionResult About(string id)
        {
            var client = ServiceHelper.GetServiceClientLoggedIn();
            return View(client.GetUser(id));
        }
        
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegistrationViewModel user)
        {
            using (var authsvc = ServiceHelper.GetAuthServiceClient())
            {
                try
                {
                    bool canRegister = authsvc.Register(user.Email, user.Name, user.Password, user.PictureURL);
                    if (!canRegister)
                        throw new InvalidOperationException("We could not register you with these credentials, please try a different E-Mail.");
                    
                    ViewBag.Message = "Click here to continue..";
                    return View();
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "A problem occured when signing you up.\n" + ex.Message;
                    throw;
                    //return View();
                }
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
