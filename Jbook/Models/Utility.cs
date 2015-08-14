using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Utility
    {
        public int UtilityId { get; set; }
        public String Name{ get; set; }
        public String Description { get; set; }
        public int LessonId { get; set; }
        public String Images { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
    }
}