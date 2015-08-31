using System;
using System.Web;
using System.Web.Http;
using FluentData;
using Jbook.Models;

namespace Jbook.Base {
    public class BaseApiController : ApiController {
        public HttpApplicationState CurrentApplicationState => HttpContext.Current.Application;

        public WxAccessToken WxAccessToken {
            get {
                var token = CurrentApplicationState["_WxAccessToken"] as WxAccessToken;

                return token == null || IsExpireForTokenTicketTime(token) ? null : token;
            }
            set {
                if (CurrentApplicationState["_WxAccessToken"] != null) CurrentApplicationState.Remove("_WxAccessToken");

                CurrentApplicationState["_WxAccessToken"] = value;
            }
        }

        public WxJsTicket WxJsTicket {
            get {
                var ticket = CurrentApplicationState["_WxJsTicket"] as WxJsTicket;

                return ticket == null || IsExpireForTokenTicketTime(ticket) ? null : ticket;
            }
            set {
                if (CurrentApplicationState["_WxJsTicket"] != null) CurrentApplicationState.Remove("_WxJsTicket");

                CurrentApplicationState["_WxJsTicket"] = value;
            }
        }

        public IDbContext Ctx => new DbContext().ConnectionStringName("Default", new SqlServerProvider());

        private bool IsExpireForTokenTicketTime(dynamic entity) {
            int expireSeconds = entity.expires_in;
            DateTime createDateTime = entity.CreateDateTime;

            return DateTime.Now >= createDateTime.AddSeconds(expireSeconds);
        }
    }
}