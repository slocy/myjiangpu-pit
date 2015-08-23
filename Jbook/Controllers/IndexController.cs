using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class IndexController : BaseApiController {
        [HttpGet]
        [Obsolete]
        public IEnumerable<string> Get() {
            return new[] {"value1", "value2", "valueN"};
        }
    }
}