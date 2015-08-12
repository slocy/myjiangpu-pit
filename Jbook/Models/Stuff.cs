using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Stuff
    {
        public String StuffId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public String Images { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
        public String CreateBy { get; set; }
    }
}