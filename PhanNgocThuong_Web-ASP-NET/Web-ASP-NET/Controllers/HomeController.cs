using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ASP_NET.Context;
using Web_ASP_NET.Models;

namespace Web_ASP_NET.Controllers
{
    public class HomeController : Controller
    {
        WebAspDbEntities objWebAspDbEntities = new WebAspDbEntities();
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.ListCategory = objWebAspDbEntities.Categories.ToList();
            objHomeModel.ListProduct = objWebAspDbEntities.Products.ToList();
            return View(objHomeModel);
        }

        public ActionResult Large()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}