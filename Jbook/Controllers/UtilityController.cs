using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class UtilityController : BaseApiController {
        [HttpGet]
        public IHttpActionResult GetByBookId(int id) {
            var utilityList = Ctx.Sql("select * from utility where bookid = @0", id).QueryMany<Utility>();

            return Ok(utilityList);
        }
    }
}