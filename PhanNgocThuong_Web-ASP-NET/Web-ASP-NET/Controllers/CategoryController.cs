using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ASP_NET.Context;
using Web_ASP_NET.Models;

namespace Web_ASP_NET.Controllers
{
    public class CategoryController : Controller
    {
        WebAspDbEntities objWebAspDbEntities = new WebAspDbEntities();
        // GET: Category
        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            objHomeModel.ListCategory = objWebAspDbEntities.Categories.ToList();
            return View(objHomeModel);
        }
    }
}