using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class LessonController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult Get(int artisanId, String status)
        {
            var lessonList = base.Ctx.Sql("select * from lesson where artisanId = @artisanId and status = @status")
                .Parameter("artisanId", artisanId)
                .Parameter("status", status)
                .QueryMany<Lesson>();

            return Ok(lessonList);
        }

        public IHttpActionResult Get(int lessonId)
        {
            var lesson = base.Ctx.Sql("select * from lesson where lessonId = @lessonId")
                .Parameter("lessonId", lessonId)
                .QuerySingle<Lesson>();

            return Ok(lesson);
        }

        public IHttpActionResult PostApply(int lessonId, int customerId, bool isPaid)
        {
            throw new NotImplementedException();
        }

        public IHttpActionResult PutPaid(int lessonId, int customerId, bool isPaid)
        {
            throw new NotImplementedException();
        }
    }
}
