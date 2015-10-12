using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class ArtisanPipeline : BasePipeline {
        private ArtisanPipeline() {
        }

        public static ArtisanPipeline _() {
            return new ArtisanPipeline();
        }

        public Artisan Get(int artisanId) {
            var artisan =
                Ctx.Sql(
                    "select top 1 ArtisanId, Name, Fullname, StudioName, CellPhone, [Description], City, [Address] from dbo.Artisan where artisanId=@0",
                    artisanId).QuerySingle<Artisan>();

            return artisan;
        }

        public Artisan GetByOpenId(string openId) {
            var artisan =
                Ctx.Sql(
                    "select top 1 ArtisanId, Name, Fullname, StudioName, CellPhone, [Description], City, [Address] from dbo.Artisan where wechatid=@0",
                    openId).QuerySingle<Artisan>();

            return artisan;
        }
    }
}