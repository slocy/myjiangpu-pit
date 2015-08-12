using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class OrderController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult Get(int id)
        {
            var order = base.Ctx.Sql("select * from order where orderid = @orderid")
                .Parameter("orderid", id)
                .QuerySingle<Order>();

            return Ok(order);
        }

        public IHttpActionResult PostOrder(int customerId, int quantity, int lessonId, int utilityId, int stuffId)
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult GetByCustomerId(int id)
        {
            var orderList = base.Ctx.Sql("select * from order where customerId = @customerId")
                .Parameter("customerId", id)
                .QueryMany<Order>();

            return Ok(orderList);
        }
    }
}
