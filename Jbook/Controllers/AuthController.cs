using System;
using System.Collections.Generic;
using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class AuthController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            return Ok(new DateTime());
        }

        [HttpGet]
        public IEnumerable<string> Get() {
            return null;
        }
    }
}