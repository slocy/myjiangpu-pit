using System.Web.Http;
using FluentData;

namespace Jbook.Base {
    public class BaseApiController : ApiController {
        public IDbContext Ctx {
            get { return new DbContext().ConnectionStringName("Default", new SqlServerProvider()); }
        }
    }
}