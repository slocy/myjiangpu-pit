using Jbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jbook.Controllers
{
    public class CustomerController : Jbook.Base.BaseApiController
    {
        public IHttpActionResult Get(int id)
        {
            var customer = base.Ctx.Sql("select * from customer where customerid = @0", id).QuerySingle<Customer>();

            return Ok(customer);
        }

        public IHttpActionResult PostCustomer(int customerId, string wechatKey, string customerName, string nickname, string city, string geo)
        {
            throw new NotImplementedException();
        }
    }
}
