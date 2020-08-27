using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interface
{
    interface IBatchWriter:IWriter
    {
        void Write(List<ILoggerMessage> messages);
    }
}
