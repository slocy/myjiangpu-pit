using System;

namespace Jbook.Models {
    public class WxAccessToken {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}