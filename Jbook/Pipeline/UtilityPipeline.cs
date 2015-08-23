using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class UtilityPipeline : BasePipeline {
        private UtilityPipeline() {
        }

        public static UtilityPipeline _() {
            return new UtilityPipeline();
        }

        public List<Utility> GetByBook(int bookId) {
            var utilityList = Ctx.Sql("select * from utility where bookid = @0", bookId).QueryMany<Utility>();

            return utilityList;
        }
    }
}