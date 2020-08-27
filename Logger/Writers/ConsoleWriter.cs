using Logger.Interface;
using System;

namespace Logger.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(ILoggerMessage message)
        {
            Console.WriteLine(message.ToString());
        }

    }
}
