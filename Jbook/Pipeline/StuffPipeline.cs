using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class StuffPipeline : BasePipeline {
        private StuffPipeline() {
        }

        public static StuffPipeline _() {
            return new StuffPipeline();
        }

        public List<Stuff> GetByBook(int bookId) {
            var stuffList = Ctx.Sql("select * from stuff where stuffId = @0", bookId).QueryMany<Stuff>();

            return stuffList;
        }
    }
}