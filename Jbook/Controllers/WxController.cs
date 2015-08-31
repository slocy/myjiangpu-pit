using System;
using System.Net;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;
using Newtonsoft.Json;

namespace Jbook.Controllers {
    public class WxController : BaseApiController {
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

        [NonAction]
        private T PaserJsonRequest<T>(string url) {
            var wc = new WebClient {Proxy = null};
            var json = wc.DownloadString(url);
            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }

        /// <summary>
        ///   Get the Wechat Ticket by AppId and AppSecret
        /// </summary>
        [HttpGet]
        public IHttpActionResult GetTicket() {
            var wechatAccessTokenUrl = ConfigHelper._().GetAppSettingValue("WechatAccessTokenUrl");
            var wechatTicketGeneratorUrl = ConfigHelper._().GetAppSettingValue("WechatTicketGeneratorUrl");
            var wechatAppId = ConfigHelper._().GetAppSettingValue("WechatAppId");
            var wechatSecret = ConfigHelper._().GetAppSettingValue("WechatSecret");

            wechatAccessTokenUrl = string.Format(wechatAccessTokenUrl, wechatAppId, wechatSecret);

            var wxAccessToken = PaserJsonRequest<WxAccessToken>(wechatAccessTokenUrl);

            if (string.IsNullOrEmpty(wxAccessToken?.access_token))
                return BadRequest("Cannot get the Wechat access token!");

            wxAccessToken.CreateDateTime = DateTime.Now;
            WxAccessToken = wxAccessToken;

            wechatTicketGeneratorUrl = string.Format(wechatTicketGeneratorUrl, wxAccessToken.access_token);

            var wxJsTicket = PaserJsonRequest<WxJsTicket>(wechatTicketGeneratorUrl);

            if (string.IsNullOrEmpty(wxJsTicket?.ticket))
                return BadRequest("Cannot get the Wechat JS ticket!");

            wxJsTicket.CreateDateTime = DateTime.Now;
            WxJsTicket = wxJsTicket;

            //SaveTicketPermanently(null);
            return Ok(new {wxJsTicket.ticket});
        }

        [NonAction]
        public void SaveTicketPermanently(string ticket) {
            throw new NotImplementedException("We should store the ticket in database rather than in ApplicationState!");
        }

        [HttpGet]
        public IHttpActionResult GetOAuth() {
            return BadRequest("Not Implemented!");
        }
    }
}