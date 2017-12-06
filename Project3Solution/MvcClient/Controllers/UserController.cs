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

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: User/Create
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

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
