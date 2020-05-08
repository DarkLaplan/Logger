using Logger.Interfaces;
using System;
using System.IO;

namespace Logger.Loggers
{
    /// <summary>
    /// Class for logging messages to file with path <see LogFilePath />.
    /// </summary>
    public class FileLogger : ILogger
    {
        private const string ErrorIndicator = "Error";
        private const string WarningIndicator = "Warning";
        private const string InfoIndicator = "Info";
        private const string SuccessfulIndicator = "Sucessful";
        private const string FatalIndicator = "Fatal";

        /// <summary>
        /// Gets path of log file, where all messages will be written.
        /// </summary>
        public string LogFilePath { get; private set; }

        /// <summary>
        /// Constructor for setting path to log file.
        /// </summary>
        /// <param name="pathToLogFile"></param>
        public FileLogger(string pathToLogFile)
        {
            LogFilePath = pathToLogFile;
        }

        private string AddMessageTypeToText(string message, string typeOfMessage) => $"{typeOfMessage}-{message}";

        /// <summary>
        /// Changes path to log file in <see LogFilePath /> property.
        /// </summary>
        /// <param name="logFilePath">new path to log file.</param>
        /// <returns>True if new path exists, otherwise False.</returns>
        public bool ChangeLogFilePath(string logFilePath)
        {
            if (File.Exists(logFilePath))
            {
                LogFilePath = logFilePath;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Write message to file if path to lof file is valid and exist.
        /// </summary>
        /// <param name="message">Message to be logged to file.</param>
        public void WriteMessageToFile(string message)
        {
            if (!string.IsNullOrEmpty(LogFilePath) && File.Exists(LogFilePath))
            {
                File.AppendAllText(LogFilePath, message);
            }
        }

        /// <inheritdoc />
        public void LogError(string message)
        {
            WriteMessageToFile(AddMessageTypeToText(message, ErrorIndicator));
        }

        /// <inheritdoc />
        public void LogError(Exception exception)
        {
            WriteMessageToFile(AddMessageTypeToText(exception.Message, ErrorIndicator));
        }

        /// <inheritdoc />
        public void LogFatal(string message)
        {
            WriteMessageToFile(AddMessageTypeToText(message, FatalIndicator));
        }

        /// <inheritdoc />
        public void LogFatal(Exception exception)
        {
            WriteMessageToFile(AddMessageTypeToText(exception.Message, FatalIndicator));
        }

        /// <inheritdoc />
        public void LogInfo(string message)
        {
            WriteMessageToFile(AddMessageTypeToText(message, InfoIndicator));
        }

        /// <inheritdoc />
        public void LogInfo(Exception exception)
        {
            WriteMessageToFile(AddMessageTypeToText(exception.Message, InfoIndicator));
        }

        /// <inheritdoc />
        public void LogSuccessful(string message)
        {
            WriteMessageToFile(AddMessageTypeToText(message, SuccessfulIndicator));
        }

        /// <inheritdoc />
        public void LogWarning(string message)
        {
            WriteMessageToFile(AddMessageTypeToText(message, WarningIndicator));
        }

        /// <inheritdoc />
        public void LogWarning(Exception exception)
        {
            WriteMessageToFile(AddMessageTypeToText(exception.Message, WarningIndicator));
        }
    }
}
