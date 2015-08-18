using System;

namespace Jbook.Models {
    public class BookStep {
        public int BookStepId { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
        public string Videos { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}