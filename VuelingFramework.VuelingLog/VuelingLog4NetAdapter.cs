using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace VuelingFramework.VuelingLog
{
    public sealed class VuelingLog4NetAdapter : ITargetAdapterForLogger
    {
        private ILog log = LogManager.GetLogger(typeof(VuelingLog4NetAdapter));
        
        public TimeSpan ExecutionTime { get; set; }
        public int counter { get; set; }

        public void Debug(string message)
        {
            log.Debug(message);
        }

        public void Error(string message)
        {
            log.Error(message);
        }

        public void Exception(Exception exception, string message)
        {
            log.Error(exception.Message);
        }

        public void Fatal(string message)
        {
            log.Fatal(message);
        }

        public void Info(string message)
        {
            log.Info(message);
        }

        public void Warn(string message)
        {
            log.Warn(message);
        }
    }
}
