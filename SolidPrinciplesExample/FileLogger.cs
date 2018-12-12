using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SolidPrinciplesExample
{
    class FileLogger :ILogger
    {
        private static  FileLogger _fileLogger;
        private static readonly Mutex mutex = new Mutex();
        private FileLogger()
        {

        }
        public static FileLogger GetFileLoggerInstance()
        {
            if(_fileLogger == null)
            {
                lock(mutex)
                {
                    if(_fileLogger == null)
                    {
                        _fileLogger = new FileLogger();
                    }
                }
            }
            return _fileLogger;
        }
        public void handler(string message)
        {
            Console.WriteLine(message);
        }
      
      
    }
}
