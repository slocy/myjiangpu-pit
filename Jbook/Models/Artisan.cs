using System;

namespace Jbook.Models {
    public class Artisan {
        public int ArtisanId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string WechatId { get; set; }
        public string Cellphone { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Images { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}