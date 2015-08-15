using System;

namespace Jbook.Models {
    public class Order {
        public int OrderId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public decimal Summary { get; set; }
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public int LessonId { get; set; }
        public int UtilityId { get; set; }
        public int StuffId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}