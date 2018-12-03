using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class FileLogger :ILogger
    {
        public void handler(string error)
        {
            Console.WriteLine("error handled here");
        }
    }
}
