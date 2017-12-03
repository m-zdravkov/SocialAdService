using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcClient.Models;
using MvcClient.Helpers;
using MvcClient.AuthService;

namespace MvcClient.Controllers
{
   public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SearchQueryViewModel sqvm)
        {
            var results = ServiceHelper.GetAuthServiceClient().
                FindAds(0, 100, sqvm.Location, sqvm.Query, sqvm.Type).ToList<Ad>();
            //var results = ServiceHelper.GetAuthServiceClient().GetAds(0, 100).ToList<Ad>();
            TempData["ads"] = results;
            //Redirect to home
            return RedirectToAction("Index", "Home");
        }

        //const int RecordsPerPage = 5;

        //I am not using httpGet or httpPost because it will be used for both
        /*public ActionResult Index ( Ad model)
        {
            if (!string.IsNullOrEmpty(model.SearchButton) || model.Page.HasValue)
            {
                var entities = new  ();
                var results = entities.Products
                    .Where(p => (p.ProductName.StartsWith(model.ProductName)
                                || model.ProductName == null)
                    && (p.Price > model.Price || model.Price == null))
                    .OrderBy(p => p.ProductName);

                var pageIndex = model.Page ?? 1;
                model.SearchResults = results.ToPagedList(pageIndex, RecordsPerPage);
            }
            return View(model);
        }*/
    }
}