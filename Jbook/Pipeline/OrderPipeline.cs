using System;
using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class OrderPipeline : BasePipeline {
        private OrderPipeline() {
        }

        public static OrderPipeline _() {
            return new OrderPipeline();
        }

        public Order Get(int orderId) {
            var order = Ctx.Sql("select top 1 * from order where orderid = @orderid")
                .Parameter("orderid", orderId)
                .QuerySingle<Order>();

            return order;
        }

        public int CreateOrder(Order order) {
            throw new NotImplementedException();
        }

        public List<Order> GetByCustomer(int customerId) {
            var orderList = Ctx.Sql("select * from order where customerId = @customerId")
                .Parameter("customerId", customerId)
                .QueryMany<Order>();

            return orderList;
        }
    }
}