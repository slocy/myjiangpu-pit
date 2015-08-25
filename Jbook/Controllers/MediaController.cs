using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class MediaController : BaseApiController {
        [NonAction]
        public static string Combine(string uri1, string uri2) {
            uri1 = uri1.TrimEnd('/');
            uri2 = uri2.TrimStart('/');
            return string.Format("{0}/{1}", uri1, uri2);
        }

        [HttpGet]
        public IHttpActionResult Get(int id, string sid, string tid) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            var mediaFileId = id;
            var type = string.IsNullOrEmpty(sid) ? "IMAGE" : sid.ToUpper();
            var mode = string.IsNullOrEmpty(tid) ? "NORMAL" : tid.ToUpper();

            var mediaFile = MediaPipeline._().Get(mediaFileId, type, mode);

            if (mediaFile == null || string.IsNullOrEmpty(mediaFile.Url)) return NotFound();

            var redirectUrl = Combine(mediaFile.Host, mediaFile.Url);

            if (redirectUrl.ToUpper().StartsWith("HTTP://") || redirectUrl.ToUpper().StartsWith("HTTP://"))
                return Redirect(redirectUrl);

            return NotFound();
        }
    }
}