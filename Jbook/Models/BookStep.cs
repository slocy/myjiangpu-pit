using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class BookStep
    {
        public int BookStepId { get; set; }
        public String Name { get; set; }
        public int BookId { get; set; }
        public String Content { get; set; }
        public String Images { get; set; }
        public String Videos { get; set; }
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateBy { get; set; }
    }
}