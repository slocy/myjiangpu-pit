using System;

namespace Jbook.Models {
    public class MedialFile {
        public int MediaFileId { get; set; }
        public int ParentId { get; set; }
        public string Type { get; set; }
        public string Mode { get; set; }
        public string Class { get; set; }
        public string Host { get; set; }
        public string Url { get; set; }
        public int Dimension_X { get; set; }
        public int Dimension_Y { get; set; }
        public int Capacity { get; set; }
        public int ElapseTime { get; set; }
        public string Reference { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}