using System;

namespace Logger.Interfaces
{
    /// <summary>
    /// Interface for shared functions of logger.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs informative message.
        /// </summary>
        /// <param name="message">Text as string variable</param>
        public void LogInfo(string message);

        /// <summary>
        /// Logs informative message from exception.
        /// </summary>
        /// <param name="exception">Exception to be log.</param>
        public void LogInfo(Exception exception);

        /// <summary>
        /// Logs error message.
        /// </summary>
        /// <param name="message">Text as string variable</param>
        public void LogError(string message);

        /// <summary>
        /// Logs error message from exception.
        /// </summary>
        /// <param name="exception">Exception to be log.</param>
        public void LogError(Exception exception);

        /// <summary>
        /// Logs warning message.
        /// </summary>
        /// <param name="message">Text as string variable</param>
        public void LogWarning(string message);

        /// <summary>
        /// Logs warning message from exception.
        /// </summary>
        /// <param name="exception">Exception to be log.</param>
        public void LogWarning(Exception exception);

        /// <summary>
        /// Logs fatal message.
        /// </summary>
        /// <param name="message">Text as string variable</param>
        public void LogFatal(string message);

        /// <summary>
        /// Logs fatal message from exception.
        /// </summary>
        /// <param name="exception">Exception to be log.</param>
        public void LogFatal(Exception exception);

        /// <summary>
        /// Logs message from successful operation.
        /// </summary>
        /// <param name="message">Text as string variable</param>
        public void LogSuccessful(string message);
    }
}
