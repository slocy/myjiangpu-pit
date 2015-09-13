using System;
using System.Collections.Specialized;
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

        public bool ExistWechatCustomer(string unionId) {throw new NotImplementedException(); }

        public void ProcessWechatUserFetching(WxOauthAccessToken wxOauthAccessToken, WxUserInfo wxUserInfo) {
            if (wxOauthAccessToken == null || wxUserInfo == null || string.IsNullOrEmpty(wxOauthAccessToken.unionid)) return;

            var customer = new Customer {
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

            // todo : should save this customer entity to database.
        }
    }
}