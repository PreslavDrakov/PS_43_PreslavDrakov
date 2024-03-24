using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class LoggerProvider : ILoggerProvider
    {
        private readonly string _filePath;
        public LoggerProvider(string filePath)
        {
            _filePath = filePath;
        }

        public ILogger CreateLogger(string categoryName)
        {
            

            // Create a HashLogger instance for other logging purposes
            ILogger hashLogger = new HashLogger(categoryName);

            // Create a FileLoggerSuccessLogin instance for other logging purposes
            ILogger loggerSuccessLogin = new LoggerSuccessLogin(_filePath);

            // Create a FileLogger instance for writing to a file
            ILogger fileLogger = new FileLogger(_filePath);

            // Return the FileLogger instance
            // return fileLogger;
            // Return the HashLogger instance
            // return hashLogger;
            // Return the FileLoggerSuccessLogin instance
            return loggerSuccessLogin;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
