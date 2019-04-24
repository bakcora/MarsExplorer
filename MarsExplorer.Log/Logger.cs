using System;
using System.IO;
using MarsExplorer.Log.Helpers;

namespace MarsExplorer.Log
{
    public static class Logger
    {
        
        public static void Text(string simpleLog)
        {
            if (string.IsNullOrEmpty(simpleLog))
                return;

            LogText(simpleLog);
        }

        private static void LogText(string log, string simplePath = null)
        {
            if (string.IsNullOrEmpty(log))
                return;

            try
            {
                var logPathForText = ConfigHelper.LogPathForText;
                if (string.IsNullOrWhiteSpace(simplePath) == false)
                    logPathForText = simplePath;

                using (var fs = new FileStream(string.Format(logPathForText, DateTime.Now.ToString("dd-MM-yyyy")), FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.BaseStream.Seek(0, SeekOrigin.End);
                        sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.ffffff") + "  " + log + Environment.NewLine);
                        sw.Flush();
                    }
                }
            }
            catch
            {
                // Nothing to do :)
            }
        }
    }
}
