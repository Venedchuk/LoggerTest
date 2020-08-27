using System;

namespace Logger.Test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var logger = LoggerService.GetBatchLogger();
            logger.Debug("Hello World");
            logger.Warn("Warn World");
            logger.Fatal("Fatal World");
        }
    }
}


