using System;
using System.Web.Configuration;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class LessonController : BaseApiController {
        public IHttpActionResult Get(int id, string sid) {
            var lessonList = Ctx.Sql("select * from lesson where artisanId = @artisanId and [status] = @status")
                .Parameter("artisanId", id)
                .Parameter("status", sid)
                .QueryMany<Lesson>();

            return Ok(lessonList);
        }

        public IHttpActionResult Get(int id) {
            var lesson = Ctx.Sql("select * from lesson where lessonId = @lessonId")
                .Parameter("lessonId", id)
                .QuerySingle<Lesson>();

            return Ok(lesson);
        }

        public IHttpActionResult PostPit(string id) {
            return Ok(id);
        }

        [NonAction]
        public string GenerateQrCodeText() {
            var qrCodePrefix = WebConfigurationManager.AppSettings["QrCodePrefix"];

            if (string.IsNullOrEmpty(qrCodePrefix)) qrCodePrefix = string.Empty;

            qrCodePrefix = qrCodePrefix.Replace("|", "");

            var qrCode = Guid.NewGuid().ToString().Replace("-", string.Empty);

            return qrCodePrefix + qrCode;
        }

        public IHttpActionResult PostApply([FromBody] LessonCustomer lessonCustomer) {
            if (lessonCustomer.Quantity < 1) throw new ArgumentException("Lesson's quantity cannot be less than 1.");

            lessonCustomer.CreateBy = "API";
            lessonCustomer.UpdateBy = "API";
            lessonCustomer.Status = "CREATED";
            lessonCustomer.QrCode = string.Empty;

            for (var index = 0; index < lessonCustomer.Quantity; index++)
                lessonCustomer.QrCode += GenerateQrCodeText() + "|";

            lessonCustomer.QrCode = lessonCustomer.QrCode.Trim("|".ToCharArray());

            var result = Ctx.Insert("LessonCustomer", lessonCustomer)
                .AutoMap(x => x.LessonCustomerId, x => x.CreateDate, x => x.UpdateDate)
                .Execute();

            return Ok(result);
        }

        public IHttpActionResult PutPaid(int lessonId, int customerId, bool isPaid) {
            throw new NotImplementedException();
        }
    }
}