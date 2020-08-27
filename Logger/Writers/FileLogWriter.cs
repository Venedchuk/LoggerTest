using Logger.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger.Writers
{
    public class FileLogWriter : IBatchWriter
    {
        public FileLogWriter(string fileName)
        {
            _file = fileName;
        }

        private readonly string _file;
        private readonly object lockobject = new object();

        public void Write(List<ILoggerMessage> messages)
        {
            //thread safe
            lock (lockobject)
            {
                using StreamWriter sw = File.AppendText(_file);
                foreach (var message in messages)
                {
                    sw.WriteLine(message.ToString());
                }
            }
        }

        public void Write(ILoggerMessage message)
        {
            //thread safe
            lock (lockobject)
            {
                using StreamWriter sw = File.AppendText(_file);
                sw.WriteLine(message.ToString());
            }
        }
    }
}
