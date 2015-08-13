using System;
using System.Collections.Generic;
using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class AuthController : BaseApiController {
        public IHttpActionResult Get(int id) {
            return Ok(new DateTime());
        }

        public IEnumerable<string> Get() {
            return null;
        }
    }
}