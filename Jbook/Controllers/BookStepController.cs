using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class BookStepController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(new BookStep());
        }

        public IEnumerable<BookStep> Get()
        {
            return null;
        }
    }
}
