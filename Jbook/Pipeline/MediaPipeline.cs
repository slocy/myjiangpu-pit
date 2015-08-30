using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class MediaPipeline : BasePipeline {
        private MediaPipeline() {
        }

        public static MediaPipeline _() {
            return new MediaPipeline();
        }

        public List<MedialFile> Get(int mediaId, string type, string mode) {
            var sql =
                "SELECT * FROM dbo.MediaFile where ParentId = @parentId and [Type] = @type and Mode = @mode";

            var result = Ctx.Sql(sql)
                .Parameter("parentId", mediaId)
                .Parameter("type", type)
                .Parameter("mode", mode)
                .QueryMany<MedialFile>();

            return result;
        }
    }
}