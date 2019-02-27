using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFramework.VuelingLog
{
    interface ITargetAdapterForLogger
    {
        TimeSpan ExecutionTime { get; set; }
        int counter { get; set; }
        void Info(string message);
        void Warn(string message);
        void Debug(string message);
        void Error(string message);
        void Fatal(string message);
        void Exception(Exception exception, string message);
    }
}
