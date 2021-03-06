﻿using System;

namespace Jbook.Models {
    public class Stuff {
        public int StuffId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LessonId { get; set; }
        public int BookId { get; set; }
        public int ArtisanId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string CreateBy { get; set; }

        public Lesson Lesson { get; set; }
        public Book Book { get; set; }
        public Artisan Artisan { get; set; }
    }
}