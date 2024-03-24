using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelcomeExtended.Helpers;

namespace WelcomeExtended.Others
{
    public class Delegates
    {
        public static readonly ILogger logger = LoggerHelper.GetLogger("Hello");
        public static readonly ILogger errorLogger = LoggerHelper.GetLogger("ErrorLogger");
        public static void Log(string error)
        {
            logger.LogError(error);
        }
        public static void Log2(string error)
        {
            Console.WriteLine("- DELEGATES -");
            Console.WriteLine($"{error}");
            Console.WriteLine("- DELEGATES -");
        }
        public static void Log3(string error)
        {
            logger.LogInformation("Information message");
            logger.LogWarning("Warning message");
            logger.LogError("Error message");
        }

        public static void Log4(string logMessage)
        {
            logger.LogInformation(logMessage);
        }

        public static void Log5(string logMessage)
        {
            errorLogger.LogInformation(logMessage);
        }
    }
}
