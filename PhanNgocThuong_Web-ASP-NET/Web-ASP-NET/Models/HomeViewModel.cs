using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_ASP_NET.Context;

namespace Web_ASP_NET.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Category> Categories { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }
    }
}