using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using Jbook.Base;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class MediaController : BaseApiController {
        [NonAction]
        public static string Combine(string uri1, string uri2) {
            uri1 = uri1?.Trim().TrimEnd('/') ?? string.Empty;
            uri2 = uri2?.Trim().TrimStart('/') ?? string.Empty;

            if (uri1.ToUpper().StartsWith("HTTP") == false) uri1 = "http://";

            return $"{uri1}/{uri2}";
        }

        [NonAction]
        public static bool CheckUrlParttern(string url) {
            return url.ToUpper().StartsWith("HTTP://") || url.ToUpper().StartsWith("HTTPS://");
        }

        [HttpGet]
        public IHttpActionResult Get(int id, string sid, string tid) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            var mediaFileParentId = id;
            var type = string.IsNullOrEmpty(sid) ? "IMAGE" : sid.ToUpper();
            var mode = string.IsNullOrEmpty(tid) ? "NORMAL" : tid.ToUpper();

            var mediaFile = MediaPipeline._().Get(mediaFileParentId, type, mode);

            if (mediaFile.Count <= 0) return NotFound();

            if (mediaFile.Count == 1) {
                if (string.IsNullOrEmpty(mediaFile[0].Url)) return NotFound();

                var redirectUrl = Combine(mediaFile[0].Host, mediaFile[0].Url);

                if (CheckUrlParttern(redirectUrl)) return Redirect(redirectUrl);
            }
            else {
                var mediaFileList =
                    mediaFile.Select(mediaFileItem => Combine(mediaFileItem.Host, mediaFileItem.Url))
                        .Where(CheckUrlParttern)
                        .ToList();

                if (mediaFileList.Count <= 0) return NotFound();

                var contentType = HttpContext.Current.Request.ContentType ?? string.Empty;
                contentType = contentType.Trim().ToUpper();

                if (contentType.StartsWith("IMAGE")) return Redirect(mediaFileList[0]);
                return Ok(mediaFileList);
            }

            return NotFound();
        }
    }
}