using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    public static class LoggerHelper
    {
        private const string LogFilePath = "logLoginSuccess.txt";
        public static ILogger GetLogger(string categoryName)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerProvider(LogFilePath)); 

            return loggerFactory.CreateLogger(categoryName);
        }
        
        public static ILogger GetErrorLogger(string categoryName)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerUnsuccessLogin());

            return loggerFactory.CreateLogger(categoryName);
        }
    }
}
