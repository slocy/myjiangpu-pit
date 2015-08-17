using System;

namespace Jbook.Models {
    public class LessonCustomer {
        public int LessonCustomerId { get; set; }
        public int LessonId { get; set; }
        public int CustomerId { get; set; }
        public String Status { get; set; }
        public decimal Quantity { get; set; }
        public decimal Summary { get; set; }
        public string Comment { get; set; }
        public String QrCode { get; set; }
        public string Telephone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}