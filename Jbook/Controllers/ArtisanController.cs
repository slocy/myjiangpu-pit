using Jbook.Base;
using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers {
    public class ArtisanController : Jbook.Base.BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            var artisan = base.Ctx.Sql("select * from artisan where artisanId=@0", id).QuerySingle<Artisan>();

            return Ok(artisan);
        }

        [HttpGet]
        public IHttpActionResult Get() {
            var artisanList = base.Ctx.Sql("select * from artisan").QueryMany<Artisan>();

            return Ok(artisanList);
        }
    }
}