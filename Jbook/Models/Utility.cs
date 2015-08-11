using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Utility
    {
        public String UtilityId { get; set; }
        public String Name{ get; set; }
        public String Description { get; set; }
        public String[] images { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}