using System.Net;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace Jbook.Base {
    public class JsonDataHelper {
        [NonAction]
        public static T PaserJsonRequest<T>(string url) {
            var wc = new WebClient {Proxy = null, Encoding = Encoding.UTF8};
            var json = wc.DownloadString(url);
            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }
    }
}