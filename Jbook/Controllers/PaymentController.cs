using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class PaymentController : ApiController
    {
        public IHttpActionResult Get(int customerId, int paymentId)
        {
            return Ok(new Payment());
        }

        public IHttpActionResult PostPayment(int customerId, bool isPaid, decimal summary, string method, int quantity, int lessonId, int stuffId, int utilityId)
        {
            return Ok(new Payment());
        }

        public IHttpActionResult PutPaid(int customerId, int paymentId, bool isPaid)
        {
            return Ok(new Payment());
        }

        public IEnumerable<Payment> Get()
        {
            return null;
        }
    }
}
