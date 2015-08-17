using System;

namespace Jbook.Models {
    public class Customer {
        public int CustomerId { get; set; }
        public String WechatId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Token { get; set; }
        public string Scope { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}