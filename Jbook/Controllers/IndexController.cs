using System.Collections.Generic;
using System.Web.Http;
using Jbook.Base;

namespace Jbook.Controllers {
    public class IndexController : BaseApiController {
        // GET: api/Index
        [HttpGet]
        public IEnumerable<string> Get() {
            return new[] {"value1", "value2", "valueN"};
        }
    }
}