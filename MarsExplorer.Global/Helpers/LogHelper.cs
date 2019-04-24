using System;
using MarsExplorer.Log;
using Newtonsoft.Json;

namespace MarsExplorer.Global.Helpers
{
    public static class LogHelper
    {
        public static void Log(LogModel model)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            if (string.IsNullOrEmpty(model.Layer))
            {
                model.Layer = "MarsExplorer.Global";
            }

            model.MachineName = Environment.MachineName;

            Logger.Text(JsonConvert.SerializeObject(model));
        }

       
    }
}
