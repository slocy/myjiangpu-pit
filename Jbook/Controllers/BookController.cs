using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class BookController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok(new Book());
        }

        public IEnumerable<Book> Get()
        {
            return null;
        }
    }
}
