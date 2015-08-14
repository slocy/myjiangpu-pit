using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Jbook.Controllers {
    //public class LessonApplyBox {
    //    public int LessonId { get; set; }
    //    public int CustomerId { get; set; }
    //    public string Comment { get; set; }
    //    public decimal Price { get; set; }
    //    public int Quantity { get; set; }
    //    public string Telephone { get; set; }
    //}

    public class LessonController : Jbook.Base.BaseApiController {
        public IHttpActionResult Get(int id, String sid) {
            var lessonList = base.Ctx.Sql("select * from lesson where artisanId = @artisanId and [status] = @status")
                .Parameter("artisanId", id)
                .Parameter("status", sid)
                .QueryMany<Lesson>();

            return Ok(lessonList);
        }

        public IHttpActionResult Get(int id) {
            var lesson = base.Ctx.Sql("select * from lesson where lessonId = @lessonId")
                .Parameter("lessonId", id)
                .QuerySingle<Lesson>();

            return Ok(lesson);
        }

        public IHttpActionResult PostPit(string id) {
            return Ok(id);
        }

        public IHttpActionResult PostApply([FromBody] LessonCustomer lessonCustomer) {
            lessonCustomer.CreateBy = "API";
            lessonCustomer.UpdateBy = "API";

            var result = base.Ctx.Insert<LessonCustomer>("LessonCustomer", lessonCustomer)
                .AutoMap(x => x.LessonCustomerId, x => x.CreateDate, x => x.UpdateDate)
                .Execute();

            return Ok(result);
        }

        public IHttpActionResult PutPaid(int lessonId, int customerId, bool isPaid) {
            throw new NotImplementedException();
        }
    }
}