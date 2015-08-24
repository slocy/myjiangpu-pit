using System;
using System.Dynamic;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class ArtisanController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            var artisan = ArtisanPipeline._().Get(id);
            artisan.Books = BookPipeline._().GetByArtisanId(id);

            return Ok(artisan);
        }
    }
}