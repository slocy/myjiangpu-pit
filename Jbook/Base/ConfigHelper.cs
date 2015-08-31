using System.Web.Configuration;

namespace Jbook.Base {
    public class ConfigHelper {
        private ConfigHelper() {
        }

        public static ConfigHelper _() {
            return new ConfigHelper();
        }

        public string GetAppSettingValue(string key) {
            var value = WebConfigurationManager.AppSettings[key] ?? string.Empty;

            return value.Trim();
        }
    }
}