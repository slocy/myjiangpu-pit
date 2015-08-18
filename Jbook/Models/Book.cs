using System;

namespace Jbook.Models {
    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Stuff { get; set; }
        public string Description { get; set; }
        public string ArtisanId { get; set; }
        public string PrimaryImage { get; set; }
        public string PrimaryVideo { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CreateBy { get; set; }
    }
}