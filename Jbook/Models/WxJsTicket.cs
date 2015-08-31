using System;

namespace Jbook.Models {
    public class WxJsTicket {
        public int errcode { get; set; }
        public string errmsg { get; set; }
        public string ticket { get; set; }
        public int expires_in { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}