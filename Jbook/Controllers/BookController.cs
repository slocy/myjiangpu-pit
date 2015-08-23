using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class BookController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(BookPipeline._().GetByBookId(id));
        }

        [HttpGet]
        public IHttpActionResult Get() {
            return Ok(BookPipeline._().GetAllBooks());
        }

        [HttpGet]
        public IHttpActionResult GetByArtisan(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(BookPipeline._().GetByArtisanId(id));
        }

        [HttpGet]
        public IHttpActionResult GetSteps(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(BookPipeline._().GetStepsByBookId(id));
        }
    }
}