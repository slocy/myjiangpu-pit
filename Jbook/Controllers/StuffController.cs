using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class StuffController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult GetByBookId(int id)
        {
            var stuffList = base.Ctx.Sql("select * from stuff where stuffId = @0", id).QueryMany<Stuff>();

            return Ok(stuffList);
        }

        public IEnumerable<Stuff> Get()
        {
            return null;
        }
    }
}
