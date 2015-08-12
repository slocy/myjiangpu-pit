using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class BookStepController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult Get(int id)
        {
            var bookSteps = base.Ctx.Sql("select * from BookStep where bookid = @0", id).QueryMany<BookStep>();

            return Ok(bookSteps);
        }
    }
}
