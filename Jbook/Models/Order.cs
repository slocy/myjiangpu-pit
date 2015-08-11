using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Order
    {
        public String OrderId { get; set; }
        public String Type { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Summary { get; set; }
        public String PaymentId { get; set; }
        public String CustomerId { get; set; }
        public String LessonId { get; set; }
        public String UtilityId { get; set; }
        public String StuffId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}