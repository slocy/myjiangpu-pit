using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class PaymentController : BaseApiController {
        [HttpGet]
        public IHttpActionResult GetByCustomerId(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(PaymentPipeline._().GetByCustomer(id));
        }

        [HttpPost]
        public IHttpActionResult Create(int customerId, bool isPaid, decimal summary, string method, int quantity,
            int lessonId, int stuffId, int utilityId) {
            return Ok(PaymentPipeline._().CreatePayment(new Payment()));
        }

        [HttpPut]
        public IHttpActionResult SetPaid(int customerId, int paymentId, bool isPaid) {
            return Ok(PaymentPipeline._().SetPaid(customerId, paymentId, isPaid));
        }
    }
}