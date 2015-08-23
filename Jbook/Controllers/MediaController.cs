using System;
using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class MediaController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id, string sid, string tid, string fid) {
            throw new NotImplementedException();
        }
    }
}