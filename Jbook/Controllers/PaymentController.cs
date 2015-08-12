using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class PaymentController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult GetByCustomerId(int id)
        {
            var paymentList = base.Ctx.Sql("select * from payment where paymentId = @0", id).QueryMany<Payment>();

            return Ok(paymentList);
        }

        public IHttpActionResult PostPayment(int customerId, bool isPaid, decimal summary, string method, int quantity, int lessonId, int stuffId, int utilityId)
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult PutPaid(int customerId, int paymentId, bool isPaid)
        {
            throw new NotImplementedException();
        }
    }
}
