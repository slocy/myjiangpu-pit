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

        public Customer Save(Customer customer) {
            if (string.IsNullOrEmpty(customer.Nickname)) return null;

            if (customer.CustomerId == 0) Ctx.Insert("Customer", customer).AutoMap(x => x.CustomerId).Execute();
            else Ctx.Update("Customer", customer).Execute();

            return customer;
        }

        public Customer FindByUnionId(string unionId) {
            var sql = "select top 1 * from customer where unionid = @0";

            return Ctx.Sql(sql, unionId).QuerySingle<Customer>();
        }

        public Customer FindByOpenId(string openid) {
            var sql = "select top 1 * from customer where openid = @0";

            return Ctx.Sql(sql, openid).QuerySingle<Customer>();
        }

        public Customer ProcessWechatUserFetching(WxOauthAccessToken wxOauthAccessToken, WxUserInfo wxUserInfo) {
            if (wxOauthAccessToken == null || wxUserInfo == null || string.IsNullOrEmpty(wxOauthAccessToken.openid))
                return null;

            var customer = FindByOpenId(wxOauthAccessToken.openid);

            if (customer != null && string.IsNullOrEmpty(customer.Nickname) == false) return customer;

            customer = new Customer {
                UpdateDate = DateTime.Now,
                Cellphone = "",
                City = wxUserInfo.city,
                Country = wxUserInfo.country,
                CreateBy = "API",
                CreateDate = DateTime.Now,
                Email = "",
                Gender = wxUserInfo.sex,
                HeadImgUrl = wxUserInfo.headimgurl,
                Name = "",
                Nickname = wxUserInfo.nickname,
                OpenId = wxUserInfo.openid,
                UnionId = wxUserInfo.unionid
            };

            return Save(customer);
        }
    }
}