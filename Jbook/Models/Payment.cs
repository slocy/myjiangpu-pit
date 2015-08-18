using System;

namespace Jbook.Models {
    public class Payment {
        public int PaymentId { get; set; }
        public decimal Summary { get; set; }
        public bool IsPaid { get; set; }
        public string Transaction { get; set; }
        public string Method { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}