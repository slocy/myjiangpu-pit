using System;

namespace Jbook.Models {
    public class Customer {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Cellphone { get; set; }
        public string OpenId { get; set; }
        public string UnionId { get; set; }
        public string Privilege { get; set; }
        public string HeadImgUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}