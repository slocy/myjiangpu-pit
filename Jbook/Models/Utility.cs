using System;

namespace Jbook.Models {
    public class Utility {
        public int UtilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LessonId { get; set; }
        public string Images { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}