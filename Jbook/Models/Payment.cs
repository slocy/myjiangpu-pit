using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public Decimal Summary { get; set; }
        public Boolean IsPaid { get; set; }
        public String Transaction { get; set; }
        public String Method { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
    }
}