using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Configuration
    {
        public String KeyName { get; set; }
		public String Value { get; set; }
        public String CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public String UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}