﻿using System.Web.Mvc;
using BOL;

namespace LinkHubUI.Areas.User.Controllers
{
    public class URLController : Controller
    {
        // GET: User/URL
        public ActionResult Index()
        {
            LinkHubModel db = new LinkHubModel();
            ViewBag.CategoryId = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Url obj)
        {
            LinkHubModel db = new LinkHubModel();
            ViewBag.CategoryId = new SelectList(db.tbl_Category, "CategoryId", "CategoryName");
            return View();
        } 
    }
}