using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class OrderController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(OrderPipeline._().Get(id));
        }

        [HttpPost]
        public IHttpActionResult PostOrder(int customerId, int quantity, int lessonId, int utilityId, int stuffId) {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IHttpActionResult GetByCustomerId(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(OrderPipeline._().GetByCustomer(id));
        }
    }
}