using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class LogProxy
    {
        public readonly string Message;
        public readonly Exception Exception;
        public static readonly LogProxy self = new LogProxy();

        public LogProxy()
        {
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File("Logs\\log.txt",
                                          restrictedToMinimumLevel: LogEventLevel.Information,
                                          outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
                            .CreateLogger();
        }

        public static void LogEx(string message, Exception exception = null)
        {
            if (message == null) throw new ArgumentNullException("message");
            if (message == string.Empty) throw new ArgumentException("empty", "message");

            Log.Error(exception, "There's an Exception in function{}");
        }
        public static void LogEx(string message, string exception = null)
        {
            if (message == null) throw new ArgumentNullException("message");
            if (message == string.Empty) throw new ArgumentException("empty", "message");

            Log.Error(exception, "There's an Exception in function{}");
        }
    }
}
