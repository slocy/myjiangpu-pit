using System.Collections.Generic;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class StuffController : BaseApiController {
        public IHttpActionResult GetByBookId(int id) {
            var stuffList = Ctx.Sql("select * from stuff where stuffId = @0", id).QueryMany<Stuff>();

            return Ok(stuffList);
        }

        public IEnumerable<Stuff> Get() {
            return null;
        }
    }
}