using Logger.Loggers;
using System;

namespace LoggerManualTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();


            logger.LogSuccessful("Successful result logged.");
            Console.WriteLine("Empty");

            logger.LogError("Error logged.");
            Console.WriteLine("Empty");

            logger.LogInfo("Info logged.");
            Console.WriteLine("Empty");

            logger.LogWarning("Warning logged.");
            Console.WriteLine("Empty");

            logger.LogFatal("FatalProblem.");
            Console.WriteLine("Empty");

            logger.ChangeColors(ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.White);

            logger.LogSuccessful("Successful result logged.");
            Console.WriteLine("Empty");

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
