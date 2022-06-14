using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SingletonMVC.Logger
{
    public sealed class Log : ILogger
    {
        private Log()
        {
        }

        private static readonly Log instance = new Log();

        public static Log GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString() + " : " + message);

            using(StreamWriter write = new StreamWriter(logFilePath, true))
            {
                write.Write(sb.ToString());
                write.Flush();
            }
        }
    }
}