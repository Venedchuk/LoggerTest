using Logger.Interface;
using Logger.Writers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Test
{
    public static class LoggerService
    {
        private static readonly LoggerBatch _logger;

        static LoggerService()
        {
            var writer = new WriterPool(new List<IWriter> { new FileLogWriter("rndFile2.txt"), new ConsoleWriter() });
            _logger = new LoggerBatch(writer);


        }
        public static ILogger GetBatchLogger()
        {
            return _logger;
        }
    }
}
