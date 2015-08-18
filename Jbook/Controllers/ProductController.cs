using System;
using System.Linq;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    [Obsolete]
    public class ProductController : BaseApiController {
        private readonly Product[] products = {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 5},
            new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        public IHttpActionResult Get(int id) {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        public IHttpActionResult Get(int id, int sid, int tid) {
            var z = "";

            var books = Ctx.Sql("select * from stuff").QueryMany<Stuff>();

            return Ok(books);
        }
    }
}