using Logger.Abstract;
using Logger.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerBatch : LoggerBase
    {
        private readonly WriterPool _writers;

        public LoggerBatch(WriterPool writers)
        {
            _writers = writers;
        }

        protected override void WriteLog(LogLevel level, string message)
        {
            
            var logMessage = GetLoggerMessage(level, message);
            _writers.Write(logMessage);
        }
    }
}
