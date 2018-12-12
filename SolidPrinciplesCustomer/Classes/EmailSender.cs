using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    class EmailSender :INotifierBase
    {
        public string EmailAddress { get; set; }
        public void notify(string message)
        {
            //write code to send email
         
        }
    }
}
