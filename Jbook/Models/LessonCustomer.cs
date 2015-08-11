using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class LessonCustomer
    {
        public String LessonCustomerId { get; set; }
        public String LessonId { get; set; }
        public String CustomerId { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Summary { get; set; }
        public String Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}