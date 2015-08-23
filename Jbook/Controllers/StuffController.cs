using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class StuffController : BaseApiController {
        [HttpGet]
        public IHttpActionResult GetByBookId(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(StuffPipeline._().GetByBook(id));
        }
    }
}