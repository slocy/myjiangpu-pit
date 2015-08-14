using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jbook.Models
{
    public class SystemLog
    {
        public int LogId { get; set; }
        public String Title { get; set; }
        public String Message { get; set; }
        public String Level { get; set; }
        public String  Source { get; set; }
        public String InnerMessage  { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}