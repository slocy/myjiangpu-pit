using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class OrderController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(new Order());
        }

        public IHttpActionResult PostOrder(int customerId, int quantity, int lessonId, int utilityId, int stuffId)
        {
            return Ok(new Order());
        }

        public IEnumerable<Order> Get()
        {
            return null;
        }
    }
}
