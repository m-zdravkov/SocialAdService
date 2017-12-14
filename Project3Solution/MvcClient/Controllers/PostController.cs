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
                using (var client = ServiceHelper.GetServiceClientLoggedIn())
                {
                    client.ReserveAd(id);
                    ViewBag.SuccessMessage = "Ad reserved successfully.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Unable to reserve ad.\n";
                ViewBag.ErrorMessage += ex.Message;
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Delete(string id)
        {
            try
            {
                using (var client = ServiceHelper.GetServiceClientLoggedIn())
                {
                    client.DeleteAd(id);
                    ViewBag.SuccessMessage = "Ad deleted successfuly.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Unable to delete ad.\n";
                ViewBag.ErrorMessage += ex.Message;
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Display(string id)
        {
            if (id == null)
                return RedirectToAction("Index", "Home");

            var client = ServiceHelper.GetAuthServiceClient();
            var ad = client.GetAd(id);
            var comments = client.GetAdReplies(0, 64, id);
            var adWithComments = new AdWithCommentsViewModel
            {
                Ad = ad,
                Comments = comments,
            };

            return View(adWithComments);
        }

        [HttpPost]
        public ActionResult Comment(PostCommentViewModel comment)
        {
            var client = ServiceHelper.GetServiceClientLoggedIn();
            client.PostComment(comment.Id, comment.Content);

            //Back to the ad
            return RedirectToAction("Display", new { id = comment.Id });
        }
    }
}