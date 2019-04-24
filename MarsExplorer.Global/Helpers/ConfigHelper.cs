using System.Configuration;
namespace MarsExplorer.Global.Helpers
{
    public static class ConfigHelper
    {
        private static string GetKey(string key)
        {
            var setting = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(setting))
                return string.Empty;
            return setting;
        }

        #region Log

        private static string _logPathForText;
        public static string LogPathForText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_logPathForText) == false)
                    return _logPathForText;

                _logPathForText = GetKey("LogPathForText");
                return _logPathForText;
            }
        }

        #endregion

    }
}
