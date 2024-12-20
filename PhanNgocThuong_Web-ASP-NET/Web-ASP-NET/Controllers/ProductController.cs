using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ASP_NET.Context;

namespace Web_ASP_NET.Controllers
{
    public class ProductController : Controller
    {
        WebAspDbEntities objWebAspDbEntities = new WebAspDbEntities();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            var objProduct = objWebAspDbEntities.Products.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }
    }
}