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
        public ActionResult Index()
        {
            var urls = obj.GetAll();

            return View(urls);
        }
    }
}