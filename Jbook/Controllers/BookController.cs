using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers {
    public class BookController : Jbook.Base.BaseApiController {
        public IHttpActionResult Get(int id) {
            var book = base.Ctx.Sql("select * from book where bookid = @0", id).QuerySingle<Book>();

            return Ok(book);
        }

        public IHttpActionResult Get() {
            var books = base.Ctx.Sql("select * from book").QueryMany<Book>();

            return Ok(books);
        }

        public IHttpActionResult GetSteps(int id) {
            var bookSteps = base.Ctx.Sql("select * from BookStep where bookid = @0", id).QueryMany<BookStep>();

            return Ok(bookSteps);
        }
    }
}