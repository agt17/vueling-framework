using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelingFramework.VuelingLog
{
    public class VuelingSerilogAdapter : ITargetAdapterForLogger
    {
        private readonly string path = "Logs/VuelingSerilog.txt";
        public VuelingSerilogAdapter()
        {
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.File(path,
                            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                        .MinimumLevel.Verbose()
                        .CreateLogger();
        }

        public TimeSpan ExecutionTime { get; set; }
        public int counter { get; set; }

        public void Debug(string message)
        {
            Log.Debug(message);
            Log.CloseAndFlush();
        }

        public void Error(string message)
        {
            Log.Error(message);
            Log.CloseAndFlush();
        }

        public void Exception(Exception exception, string message)
        {
            Log.Error(exception.Message);
            Log.CloseAndFlush();
        }

        public void Fatal(string message)
        {
            Log.Fatal(message);
            Log.CloseAndFlush();
        }

        public void Info(string message)
        {
            Log.Information(message);
            Log.CloseAndFlush();
        }

        public void Warn(string message)
        {
            Log.Warning(message);
            Log.CloseAndFlush();
        }
    }
}
