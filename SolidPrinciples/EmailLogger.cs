using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class EmailLogger : ILogger
    {
        public void handler(string error)
        {
            Console.WriteLine("Email Error handler");
        }
    }
}
