using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class BookStep
    {
        public String StepId { get; set; }
        public String Name { get; set; }
        public String BookId { get; set; }
        public String Content { get; set; }
        public String[] Images { get; set; }
        public String[] Videos { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}