using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interface
{
    public interface IWriter
    {
        public void Write(ILoggerMessage message);
    }
}
