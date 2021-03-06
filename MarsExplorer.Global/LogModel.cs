﻿using System;

namespace MarsExplorer.Global
{
    public class LogModel
    {
        public LogModel()
        {
            ApplicationName = "MarsExplorer";
            Application = "MarsExplorer";
        }

        public string ApplicationName { get; private set; }
        public string Application { get; private set; }
        public string Layer { get; set; }
        public string MachineName { get; set; }
        public string EventType { get; set; }
        public string Priority { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public string MessageDetail { get; set; }
        public object Exception { get; set; }
        public object User { get; set; }
        public object Client { get; set; }
        public object Extra { get; set; }
        public object Performance { get; set; }

        /// <summary>
        /// yyyy-MM-ddTHH:mm:ss.fffffffzzz
        /// </summary>
        public DateTime CreationDate { get; set; }
    }
}
