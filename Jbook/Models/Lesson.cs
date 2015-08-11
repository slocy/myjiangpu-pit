﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Lesson
    {
        public String LessonId { get; set; }
        public String Title { get; set; }
        public String Comment { get; set; }
        public String ArtisanId { get; set; }
        public String BookId { get; set; }
        public String Datetime { get; set; }
        public String Place { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}