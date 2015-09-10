using System;
using System.Collections.Generic;
using System.Web.Configuration;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class LessonPipeline : BasePipeline {
        private LessonPipeline() {
        }

        public static LessonPipeline _() {
            return new LessonPipeline();
        }

        public List<Lesson> GetByArtisan(int artisanId, string status) {
            var sql =
                "select LessonId, Title, [Status], Comment, ArtisanId, BookId, ScheduleDate, Place, Price from lesson where artisanId = @artisanId";

            if (string.IsNullOrWhiteSpace(status) == false) sql = sql + " and [status] = @status";

            var context = Ctx.Sql(sql)
                .Parameter("artisanId", artisanId);

            if (string.IsNullOrWhiteSpace(status) == false)
                context.Parameter("status", status);

            var lessonList = context.QueryMany<Lesson>();

            return lessonList;
        }

        public Lesson Get(int lessonId) {
            var sql = "SELECT LessonId, Title, [Status], Comment, ArtisanId, BookId, ScheduleDate, Place, Price FROM dbo.Lesson where LessonId = @lessonId";

            var lesson = Ctx.Sql(sql).Parameter("lessonId", lessonId).QuerySingle<Lesson>();

            return lesson;
        }

        public int Apply(LessonCustomer lessonCustomer) {
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

            return result;
        }

        private string GenerateQrCodeText() {
            var qrCodePrefix = WebConfigurationManager.AppSettings["QrCodePrefix"];

            if (string.IsNullOrEmpty(qrCodePrefix)) qrCodePrefix = string.Empty;

            qrCodePrefix = qrCodePrefix.Replace("|", "");

            var qrCode = Guid.NewGuid().ToString().Replace("-", string.Empty);

            return qrCodePrefix + qrCode;
        }

        public int SetPaid(int lessonId, int customerId, bool isPaid) {
            throw new NotImplementedException();
        }

        public List<Lesson> GetByBook(int bookId) {
            var sql = "select * from dbo.Lesson where BookId = @bookId";

            return base.Ctx.Sql(sql).Parameter("bookId", bookId).QueryMany<Lesson>();
        } 
    }
}