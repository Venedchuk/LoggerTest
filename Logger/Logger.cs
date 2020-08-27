using Logger.Abstract;
using Logger.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Logger : LoggerBase
    {
        private readonly IWriter _writer;

        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        protected override void WriteLog(LogLevel level, string message)
        {
           var logMessage = GetLoggerMessage(level, message);
            _writer.Write(logMessage);
        }

    }
}
