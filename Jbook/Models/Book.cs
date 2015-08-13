using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class Book
    {
        public String BookId { get; set; }
        public String Title { get; set; }
        public String SubTitle { get; set; }
        public String Stuff { get; set; }
        public String Description { get; set; }
        public String ArtisanId { get; set; }
        public String PrimaryImage { get; set; }
        public String PrimaryVedio { get; set; }
        public String[] Images { get; set; }
        public DateTime CreateDate { get; set; }
        public String UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String CreateBy { get; set; }
    }
}