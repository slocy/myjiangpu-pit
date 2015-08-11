﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Customer
    {
        public String WechatId { get; set; }
        public String Name { get; set; }
        public String Nickname { get; set; }
        public Boolean Gender { get; set; }
        public String Email { get; set; }
        public String Cellphone { get; set; }
        public String Token { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}