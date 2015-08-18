using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class OrderController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            var order = Ctx.Sql("select * from order where orderid = @orderid")
                .Parameter("orderid", id)
                .QuerySingle<Order>();

            return Ok(order);
        }

        [HttpPost]
        public IHttpActionResult PostOrder(int customerId, int quantity, int lessonId, int utilityId, int stuffId) {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IHttpActionResult GetByCustomerId(int id) {
            var orderList = Ctx.Sql("select * from order where customerId = @customerId")
                .Parameter("customerId", id)
                .QueryMany<Order>();

            return Ok(orderList);
        }
    }
}