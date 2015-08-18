using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class CustomerController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            var customer = Ctx.Sql("select * from customer where customerid = @0", id).QuerySingle<Customer>();

            customer.WechatId = string.Empty;

            return Ok(customer);
        }

        [HttpPost]
        public IHttpActionResult PostCustomer(int customerId, string wechatKey, string customerName, string nickname,
            string city, string geo) {
            throw new NotImplementedException();
        }
    }
}