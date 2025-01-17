using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_ASP_NET.Context;

namespace Web_ASP_NET.Models
{
    public class HomeModel
    {
        public List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }
        public List<Brand> ListBrand { get; set; }
    }
}