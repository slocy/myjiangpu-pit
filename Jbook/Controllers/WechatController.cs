using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class WechatController : BaseApiController {
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