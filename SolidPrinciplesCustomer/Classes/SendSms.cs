using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
     class SendSms :INotifierBase
    {
        public void notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
