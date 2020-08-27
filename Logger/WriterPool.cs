using Logger.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Logger
{
    public class WriterPool : IBatchWriter
    {
        public WriterPool(IEnumerable<IWriter> writers)
        {
            this.writers = writers;
        }
        private readonly IEnumerable<IWriter> writers;
        public void Write(ILoggerMessage message)
        {
            Parallel.ForEach(writers, writer =>
            {
                writer.Write(message);
            });
        }
        public void Write(List<ILoggerMessage> messages)
        {
            foreach (var message in messages)
            {
                Parallel.ForEach(writers, writer =>
                {
                    writer.Write(message);
                });
            }
        }


    }
}
