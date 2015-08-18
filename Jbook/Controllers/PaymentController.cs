using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class PaymentController : BaseApiController {
        [HttpGet]
        public IHttpActionResult GetByCustomerId(int id) {
            var paymentList = Ctx.Sql("select * from payment where paymentId = @0", id).QueryMany<Payment>();

            return Ok(paymentList);
        }

        [HttpPost]
        public IHttpActionResult Create(int customerId, bool isPaid, decimal summary, string method, int quantity,
            int lessonId, int stuffId, int utilityId) {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IHttpActionResult SetPaid(int customerId, int paymentId, bool isPaid) {
            throw new NotImplementedException();
        }
    }
}