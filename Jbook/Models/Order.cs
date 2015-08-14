using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public String Type { get; set; }
        public int Quantity { get; set; }
        public decimal Summary { get; set; }
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int LessonId { get; set; }
        public int UtilityId { get; set; }
        public int StuffId { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
    }
}