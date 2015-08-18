using System;

namespace Jbook.Models {
    public class Lesson {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public int ArtisanId { get; set; }
        public int BookId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string Place { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}