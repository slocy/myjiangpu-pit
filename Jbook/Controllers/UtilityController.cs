using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class UtilityController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult GetByBookId(int id)
        {
            var utilityList = base.Ctx.Sql("select * from utility where bookid = @0", id).QueryMany<Utility>();

            return Ok(utilityList);
        }
    }
}
