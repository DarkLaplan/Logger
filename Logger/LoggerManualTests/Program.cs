using Logger.Loggers;
using System;

namespace LoggerManualTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            logger.LogError("Error logged.");
            Console.WriteLine("Empty");

            logger.LogInfo("Info logged.");
            Console.WriteLine("Empty");

            logger.LogWarning("Warning logged.");
            Console.WriteLine("Empty");

            logger.LogFatal("FatalProblem.");
            Console.WriteLine("Empty");
        }
    }
}
