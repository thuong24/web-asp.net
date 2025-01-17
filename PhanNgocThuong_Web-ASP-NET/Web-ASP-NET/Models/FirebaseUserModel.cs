using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_ASP_NET.Models
{
    public class FirebaseUserModel
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Uid { get; set; }
        public string Provider { get; set; }
    }
}