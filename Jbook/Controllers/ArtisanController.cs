using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class ArtisanController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            var artisan = Ctx.Sql("select * from artisan where artisanId=@0", id).QuerySingle<Artisan>();

            return Ok(artisan);
        }

        [HttpGet]
        public IHttpActionResult Get() {
            var artisanList = Ctx.Sql("select * from artisan").QueryMany<Artisan>();

            return Ok(artisanList);
        }
    }
}