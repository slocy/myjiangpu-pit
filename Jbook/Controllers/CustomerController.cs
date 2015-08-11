using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class CustomerController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(new Customer()); ;
        }

        public IEnumerable<Customer> Get()
        {
            return null;
        }
    }
}
