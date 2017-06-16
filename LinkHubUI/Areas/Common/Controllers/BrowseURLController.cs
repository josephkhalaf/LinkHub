using System;
using System.Linq;
using System.Web.Mvc;
using BLL;

namespace LinkHubUI.Areas.Common.Controllers
{
    public class BrowseURLController : Controller
    {
        private UrlBl obj;   
        public BrowseURLController()
        {
            obj = new UrlBl();
        }
        // GET: Common/BrowserURL
        public ActionResult Index(string sortOrder, string sortBy, string page)
        {
            ViewBag.SortOrder = sortOrder;
            ViewBag.SortBy = sortBy;

            var urls = obj.GetAll().Where(o => o.IsApproved == "A");

            switch (sortOrder)
            {
                case "Asc":
                    urls = urls.OrderBy(o => o.UrlTitle).ToList();
                    break;
                case "Desc":
                    urls = urls.OrderByDescending(o => o.UrlTitle).ToList();
                    break;
            }

            ViewBag.TotalPages = Math.Ceiling((double) (obj.GetAll().Where(x => x.IsApproved == "A").Count() / 10));
            int _page = int.Parse(page == null ? "1" : page);
            ViewBag.Page = _page;

            urls = urls.Skip((_page - 1) * 10).Take(10);
            return View(urls);
        }
    }
}