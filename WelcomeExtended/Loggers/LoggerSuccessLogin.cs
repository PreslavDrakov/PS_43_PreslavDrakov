using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class LoggerSuccessLogin : ILogger
    {
        private readonly string _filePath;
        private readonly object _lock = new object();

        public LoggerSuccessLogin(string filePath)
        {
            _filePath = filePath;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null; 
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            lock (_lock)
            {
                string logMessage = formatter(state, exception);
                string formattedMessage = $"{DateTime.Now} [{logLevel}] - {logMessage}";
                File.AppendAllText(_filePath, formattedMessage + Environment.NewLine);
            }
        }
    }
}
