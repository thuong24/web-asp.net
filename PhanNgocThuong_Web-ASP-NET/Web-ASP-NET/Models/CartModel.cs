using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_ASP_NET.Context;

namespace Web_ASP_NET.Models
{
    public class CartModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}