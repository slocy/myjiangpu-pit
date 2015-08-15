using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class WechatController : BaseApiController {
        /*
            #1 Access the URL: https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}
            #2 Get the response as below:
                {
                    access_token: "xxxxxxxxxx",
                    expires_in: 7200
                }
            #3 Forward the access_token to URL: https://api.weixin.qq.com/cgi-bin/ticket/getticket?type=jsapi&access_token={0}
            #4 Get the response from JSON
                {
                    errcode: 0,
                    errmsg: "ok",
                    ticket: "xxxxxxxxxxx",
                    expires_in: 7200
                }
            #5 The ticket can be used in 2 hours.
        */

        /// <summary>
        /// Get the Wechat Ticket by AppId and AppSecret
        /// </summary>
        public IHttpActionResult GetTicket() {
            SaveTicketPermanently(null);

            return BadRequest("Not Implemented!");
        }

        [NonAction]
        public void SaveTicketPermanently(string ticket) {
        }

        public IHttpActionResult GetOAuth() {
            return BadRequest("Not Implemented!");
        }
    }
}