using Logger.Interfaces;
using System;

namespace Logger.Loggers
{
    /// <summary>
    /// Class for logging messages to console window.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Gets color for info message.
        /// </summary>
        public ConsoleColor InfoColor { get; private set; } = ConsoleColor.Cyan;

        /// <summary>
        /// Gets color for error message.
        /// </summary>
        public ConsoleColor ErrorColor { get; private set; } = ConsoleColor.DarkRed;

        /// <summary>
        /// Gets color for warning message.
        /// </summary>
        public ConsoleColor WarningColor { get; private set; } = ConsoleColor.DarkYellow;

        /// <summary>
        /// Gets color for fatal problem message.
        /// </summary>
        public ConsoleColor FatalColor { get; private set; } = ConsoleColor.DarkMagenta;

        /// <summary>
        /// Basic empty constructor.
        /// </summary>
        public ConsoleLogger()
        {

        }

        /// <summary>
        /// Constructor which override default color setting of message type like error, warning, ...
        /// </summary>
        /// <param name="infoColor">Color for info.</param>
        /// <param name="errorColor">Color for error.</param>
        /// <param name="warningColor">Color for warning.</param>
        /// <param name="fatalColor">Color for fatal problem.</param>
        public ConsoleLogger(ConsoleColor infoColor, ConsoleColor errorColor, ConsoleColor warningColor, ConsoleColor fatalColor)
        {
            ChangeColors(infoColor, errorColor, warningColor, fatalColor);
        }

        /// <summary>
        /// Change colors of individual message types.
        /// </summary>
        /// <param name="infoColor">Color for info.</param>
        /// <param name="errorColor">Color for error.</param>
        /// <param name="warningColor">Color for warning.</param>
        /// <param name="fatalColor">Color for fatal problem.</param>
        public void ChangeColors(ConsoleColor infoColor, ConsoleColor errorColor, ConsoleColor warningColor, ConsoleColor fatalColor)
        {
            InfoColor = infoColor;
            ErrorColor = errorColor;
            WarningColor = warningColor;
            FatalColor = fatalColor;
        }

        /// <summary>
        /// Logs string message with specific color to console.
        /// </summary>
        /// <param name="message">Message to log.</param>
        /// <param name="color">Color to be used.</param>
        public void LogMessageToConsole(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <inheritdoc />
        public void LogError(string message)
        {
            LogMessageToConsole(message, ErrorColor);
        }

        /// <inheritdoc />
        public void LogError(Exception exception)
        {
            LogMessageToConsole(exception.Message, ErrorColor);
        }

        /// <inheritdoc />
        public void LogFatal(string message)
        {
            LogMessageToConsole(message, FatalColor);
        }

        /// <inheritdoc />
        public void LogFatal(Exception exception)
        {
            LogMessageToConsole(exception.Message, FatalColor);
        }

        /// <inheritdoc />
        public void LogInfo(string message)
        {
            LogMessageToConsole(message, InfoColor);
        }

        /// <inheritdoc />
        public void LogInfo(Exception exception)
        {
            LogMessageToConsole(exception.Message, InfoColor);
        }

        /// <inheritdoc />
        public void LogWarning(string message)
        {
            LogMessageToConsole(message, WarningColor);
        }

        /// <inheritdoc />
        public void LogWarning(Exception exception)
        {
            LogMessageToConsole(exception.Message, WarningColor);
        }
    }
}
