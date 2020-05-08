using Logger.Loggers;
using System.IO;
using Xunit;

namespace Logger.Tests
{
    public class FileLoggerTests
    {
        [Fact]
        public void LogError_LogNormalMessage_MessageIsInFile()
        {
            // Arrange
            var pathToLogFile = Path.GetFullPath("EmptyLogFile.txt");
            var fileLogger = new FileLogger(pathToLogFile);
            var expected = "New Error message";

            // Act
            fileLogger.LogError(expected);
            expected = "[Error] - " + expected;
            var actual = File.ReadAllText(pathToLogFile);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
