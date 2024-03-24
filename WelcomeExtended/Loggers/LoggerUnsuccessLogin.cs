using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class LoggerUnsuccessLogin : ILoggerProvider
    {
        private readonly string _errorLogFilePath = "errorLog.txt";

        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(_errorLogFilePath);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
