using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesExample
{
    class EmailSender :ILogger
    {
        public void handler(string message)
        {
            Console.WriteLine("Email is sent with a message :" +message);
        }

    }
}
