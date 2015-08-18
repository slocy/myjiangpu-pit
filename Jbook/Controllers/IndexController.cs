using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Controllers {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class IndexController : BaseApiController {
        private readonly Product[] products = {
            new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 5},
            new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M},
            new Product {Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M}
        };

        // GET: api/Index
        [HttpGet]
        [Obsolete]
        public IEnumerable<string> Get() {
            return new[] {"value1", "value2", "valueN"};
        }

        [HttpGet]
        [Obsolete]
        public IHttpActionResult Get(int id) {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        [Obsolete]
        public IHttpActionResult Get(int id, int sid, int tid) {
            var z = "";

            var books = Ctx.Sql("select * from stuff").QueryMany<Stuff>();

            return Ok(books);
        }
    }
}