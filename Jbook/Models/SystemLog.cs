using System;

namespace Jbook.Models {
    public class SystemLog {
        public int LogId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public string Source { get; set; }
        public string InnerMessage { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}