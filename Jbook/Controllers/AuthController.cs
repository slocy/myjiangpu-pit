using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class AuthController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(new DateTime());
        }

        public IEnumerable<String> Get()
        {
            return null;
        }
    }
}
