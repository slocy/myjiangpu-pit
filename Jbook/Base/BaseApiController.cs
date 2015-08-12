using FluentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Jbook.Base
{
    public class BaseApiController : ApiController
    {
        public IDbContext Ctx
        {
            get { return new DbContext().ConnectionStringName("Default", new SqlServerProvider()); }
        }
    }
}