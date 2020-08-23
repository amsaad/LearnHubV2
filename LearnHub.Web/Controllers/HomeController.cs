using LearnHub.ApiHelper.Lookups;
using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnHub.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LKCategory cat = new LKCategory()
            {
                Name="TestCat"
            };
            Category c = new Category();
            ViewBag.ListOfItems = c.GetAsync();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}