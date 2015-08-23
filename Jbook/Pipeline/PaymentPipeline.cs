using System;
using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class PaymentPipeline : BasePipeline {
        private PaymentPipeline() {
        }

        public static PaymentPipeline _() {
            return new PaymentPipeline();
        }

        public List<Payment> GetByCustomer(int customerId) {
            var paymentList = Ctx.Sql("select * from payment where paymentId = @0", customerId).QueryMany<Payment>();

            return paymentList;
        }

        public int CreatePayment(Payment payment) {
            throw new NotImplementedException();
        }

        public int SetPaid(int customerId, int paymentId, bool isPaid) {
            throw new NotImplementedException();
        }
    }
}