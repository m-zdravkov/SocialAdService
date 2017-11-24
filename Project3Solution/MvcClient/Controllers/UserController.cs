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
            IList < User > list = client.GetUsers(0, 100);
            return View(list);
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
            try
            {
                using (var authsvc = ServiceHelper.GetAuthServiceClient())
                {
                    bool canRegister = authsvc.Register(user.Email, user.Name, user.Password, user.PictureURL);
                    if (!canRegister)
                        throw new InvalidOperationException("Could not register with these credentials.");
                }

                //    client.Register(user.Email, user.Password, user.Name, user.PictureURL);

                ViewBag.Message = "Registration was successful.";
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "There was a problem trying to register you. Please try again.\n" + ex.Message;
                return View();
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
