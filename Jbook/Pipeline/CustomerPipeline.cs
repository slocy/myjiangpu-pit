using System;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class CustomerPipeline : BasePipeline {
        private CustomerPipeline() {
        }

        public static CustomerPipeline _() {
            return new CustomerPipeline();
        }

        public Customer Get(int customerId) {
            var customer =
                Ctx.Sql(
                    "select CustomerId, Name, Nickname, Gender, Email, Cellphone, Scope from dbo.Customer where CustomerId = @0",
                    customerId).QuerySingle<Customer>();

            return customer;
        }

        public int AddCustomer(Customer customer) {
            throw new NotImplementedException();
        }
    }
}