using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interface
{
    public interface ILoggerMessage
    {

       LogLevel Level { get; }

        DateTime LogDateTime { get; }
        
        string Message { get; }

        public string ToString();
    }
}
