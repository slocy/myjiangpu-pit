using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class LessonCustomer
    {
        public int LessonCustomerId { get; set; }
        public int LessonId { get; set; }
        public int CustomerId { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Summary { get; set; }
        public String Comment { get; set; }
        public String Telephone { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
    }
}