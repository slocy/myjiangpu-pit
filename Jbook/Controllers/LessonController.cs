using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class LessonController : ApiController
    {
        public IHttpActionResult Get(int artisanId, String status)
        {
            return Ok(new Lesson());
        }

        public IHttpActionResult Get(int lessonId)
        {
            return Ok(new Lesson());
        }

        public IHttpActionResult PostApply(int lessonId, int customerId, bool isPaid)
        {
            return Ok(new Lesson());
        }

        public IHttpActionResult PutPaid(int lessonId, int customerId, bool isPaid)
        {
            return Ok(new Lesson());
        }
    }
}
