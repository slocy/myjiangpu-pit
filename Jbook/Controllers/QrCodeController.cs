using System;
using System.Web.Http;
using Jbook.Models;

namespace Jbook.Controllers {
    public class QrCodeController : ApiController {
        [HttpGet]
        public IHttpActionResult Get(string id) {
            if (id.IndexOf('-') <= 0) throw new ArgumentException("QRCode format is incorrect!");

            if (id.ToUpper().StartsWith(DataDict.QrPrefixLessonCustomer))
                return Ok("LessonCustomer");

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ApplyLessonTicket(string id) {
            throw new NotImplementedException();
        }
    }
}