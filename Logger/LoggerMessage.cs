using Logger.Interface;
using Microsoft.Extensions.Logging;
using System;

namespace Logger
{
    public class LoggerMessage : ILoggerMessage
    {
        public LogLevel Level { get; }

        public DateTime LogDateTime { get; }

        public string Message { get; }

        public LoggerMessage(LogLevel level, string message)
        {
            Level = level;
            Message = message;
        }
        public override string ToString()
        {
            return $"[{LogDateTime}] : {Level} - {Message}";
        }

    }
}
