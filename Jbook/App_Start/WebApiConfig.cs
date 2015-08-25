using System.Linq;
using System.Web.Http;

namespace Jbook {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("Default", "{controller}/{action}/{id}/{sid}/{tid}/{fid}",
                new {
                    controller = "Index",
                    action = "Index",
                    id = "",
                    sid = "",
                    tid = "",
                    fid = ""
                }
                );

            var appXmlType =
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}