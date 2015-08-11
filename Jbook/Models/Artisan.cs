﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Artisan
    {
        public String ArtisanId { get; set; }
        public String Name { get; set; }
        public String FullName { get; set; }
        public String WechatId { get; set; }
        public String Cellphone { get; set; }
        public String Description { get; set; }
        public String City { get; set; }
        public String Address { get; set; }
        public String[] Images { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}