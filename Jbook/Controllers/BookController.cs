using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class BookController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            var book = Ctx.Sql("select * from book where bookid = @0", id).QuerySingle<Book>();

            return Ok(book);
        }

        [HttpGet]
        public IHttpActionResult Get() {
            var books = Ctx.Sql("select * from book").QueryMany<Book>();

            return Ok(books);
        }

        [HttpGet]
        public IHttpActionResult GetSteps(int id) {
            var bookSteps = Ctx.Sql("select * from BookStep where bookid = @0", id).QueryMany<BookStep>();

            return Ok(bookSteps);
        }
    }
}