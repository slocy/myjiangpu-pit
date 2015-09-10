using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class LessonController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            var lesson = LessonPipeline._().Get(id);
            lesson.Artisan = ArtisanPipeline._().Get(lesson.ArtisanId);
            lesson.Book = BookPipeline._().Get(lesson.BookId);

            return Ok(lesson);
        }

        [HttpGet]
        public IHttpActionResult GetByArtisan(int id, string sid) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(LessonPipeline._().GetByArtisan(id, sid));
        }

        [HttpGet]
        public IHttpActionResult GetByBook(int id) {
            var lessonList = LessonPipeline._().GetByBook(id);

            return Ok(lessonList);
        }

        [HttpPost]
        public IHttpActionResult Apply([FromBody] LessonCustomer lessonCustomer) {
            if (lessonCustomer.Quantity < 1) throw new ArgumentException("Lesson's quantity cannot be less than 1.");

            return Ok(LessonPipeline._().Apply(lessonCustomer));
        }

        [HttpPut]
        public IHttpActionResult SetPaid(int id, int sid, bool tid) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");
            if (sid <= 0) throw new ArgumentException("Parameter id must be not empty!");

            return Ok(LessonPipeline._().SetPaid(id, sid, tid));
        }
    }
}