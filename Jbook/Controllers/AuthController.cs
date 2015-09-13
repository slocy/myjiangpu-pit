using System;
using System.Collections.Generic;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class AuthController : BaseApiController {
        [HttpGet]
        public IHttpActionResult FetchUser(string id) {
            if (string.IsNullOrEmpty(id)) return BadRequest("Need the parameter ID!");

            try {
                var wechatOAuthRenewPathUrl = ConfigHelper._().GetAppSettingValue("WechatOAuthRenewPathUrl");
                var wechatAppId = ConfigHelper._().GetAppSettingValue("WechatAppId");
                var wechatSecret = ConfigHelper._().GetAppSettingValue("WechatSecret");
                var wechatUserInfoUrl = ConfigHelper._().GetAppSettingValue("WechatGetUserInfoUrl");

                wechatOAuthRenewPathUrl = string.Format(wechatOAuthRenewPathUrl, wechatAppId, wechatSecret, id);
                var accessToken = JsonDataHelper.PaserJsonRequest<WxOauthAccessToken>(wechatOAuthRenewPathUrl);

                wechatUserInfoUrl = string.Format(wechatUserInfoUrl, accessToken.access_token, accessToken.openid);
                var userInfo = JsonDataHelper.PaserJsonRequest<WxUserInfo>(wechatUserInfoUrl);

                CustomerPipeline._().ProcessWechatUserFetching(accessToken, userInfo);

                return Ok(new {token = accessToken, userinfo = userInfo});
            }
            catch (Exception exception) {
                return InternalServerError(exception);
            }
        }

        [HttpGet]
        public IEnumerable<string> Get() {
            return null;
        }
    }
}