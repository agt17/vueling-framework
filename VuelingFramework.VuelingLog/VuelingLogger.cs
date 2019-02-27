using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace VuelingFramework.VuelingLog
{
    public sealed class VuelingLogger : ITargetAdapterForLogger
    {
        private ILog log = LogManager.GetLogger(typeof(VuelingLogger));
        private bool isInfoEnabled = true;
        private bool isWarnEnabled = true;
        private bool isDebugEnabled = true;
        private bool isErrorEnabled = true;
        private bool isFatalEnabled = true;

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
            throw new NotImplementedException();
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
