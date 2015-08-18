using System;

namespace Jbook.Models {
    public class Configuration {
        public string KeyName { get; set; }
        public string Value { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}