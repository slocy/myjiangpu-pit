using FluentData;

namespace Jbook.Base {
    public class BasePipeline {
        public IDbContext Ctx => new DbContext().ConnectionStringName("Default", new SqlServerProvider());
    }
}