using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*namespace MvcClient.Controllers
{
   /* public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        const int RecordsPerPage = 5;

        //I am not using httpGet or httpPost because it will be used for both
        public ActionResult Index ( Ad model)
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
        }
    }
}*/