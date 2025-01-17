﻿using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_ASP_NET.Context;
using Web_ASP_NET.Models;

namespace Web_ASP_NET.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebAspDbEntities _context;
        public HomeController()
        {
            _context = new WebAspDbEntities();
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Search(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return Json(new { success = false, message = "No query provided." }, JsonRequestBehavior.AllowGet);
            }

            // Tìm kiếm sản phẩm
            var products = _context.Products
                .Where(p => p.Name.Contains(query))
                .Select(p => new
                {
                    p.Id,
                    p.Name
                }).ToList();

            var users = _context.Users
                .Where(u => (u.LastName + " " + u.FirstName).Contains(query)) // Thêm khoảng trắng giữa họ và tên
                .Select(u => new
                {
                    u.Id,
                    FullName = u.LastName + " " + u.FirstName // Kết hợp họ và tên thành FullName
                }).ToList();

            // Tìm kiếm đơn hàng (Order)
            var orders = _context.Orders
                .Where(o => o.Name.Contains(query)) // Thay 'OrderCode' bằng đúng thuộc tính chứa mã đơn hàng.
                .Select(o => new
                {
                    o.Id,
                    o.Name
                }).ToList();

            // Tìm kiếm thương hiệu (Brand)
            var brands = _context.Brands
                .Where(b => b.Name.Contains(query))
                .Select(b => new
                {
                    b.Id,
                    b.Name
                }).ToList();

            // Tìm kiếm danh mục (Category)
            var categories = _context.Categories
                .Where(c => c.Name.Contains(query))
                .Select(c => new
                {
                    c.Id,
                    c.Name
                }).ToList();

            // Trả về kết quả
            return Json(new
            {
                success = true,
                products,
                users,
                orders,
                brands,
                categories
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
