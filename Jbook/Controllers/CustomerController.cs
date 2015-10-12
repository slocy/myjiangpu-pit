using System;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;
using Jbook.Pipeline;

namespace Jbook.Controllers {
    public class CustomerController : BaseApiController {
        [HttpGet]
        public IHttpActionResult Get(int id) {
            if (id <= 0) throw new ArgumentException("Parameter id must be not empty!");

            var customer = CustomerPipeline._().Get(id);

            if (string.IsNullOrEmpty(customer.OpenId)) return Ok(customer);

            var artisan = ArtisanPipeline._().GetByOpenId(customer.OpenId);

            var result = new {Customer = customer, Artisan = artisan};

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PostCustomer(int customerId, string wechatKey, string customerName, string nickname,
            string city, string geo) {
            return Ok(CustomerPipeline._().Save(new Customer()));
        }
    }
}