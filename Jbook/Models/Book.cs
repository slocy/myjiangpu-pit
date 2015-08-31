using System;
using System.Collections.Generic;

namespace Jbook.Models {
    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string StuffInfo { get; set; }
        public string Description { get; set; }
        public int ArtisanId { get; set; }
        public bool IsHidden { get; set; }
        public string PrimaryImage { get; set; }
        public string PrimaryVideo { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CreateBy { get; set; }

        public Artisan Artisan { get; set; }
        public List<BookStep> Steps { get; set; }
        public List<Stuff> Stuffs { get; set; }
        public List<Utility> Utilities { get; set; }
        public List<MedialFile> Images { get; set; }
        public List<MedialFile> Videos { get; set; }  
    }
}