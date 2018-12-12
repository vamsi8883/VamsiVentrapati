using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    class OnlineOrder : OrderProcessorOnline
    {
        //private static EmailSender _emailSender;
        //private static SendSms _sms;
        public INotifierBase notifierBase;
        public OnlineOrder(INotifierBase notifier)
        {
            notifierBase = notifier;
           // _emailSender = new EmailSender();
        }
        public override void ProcessOrder()
        {
           
            // order processing
            //_emailSender.notify("abc@gmail.com", "Your order is processed");
            //_sms.notify("your order is processed");
            
            notifierBase.notify("your order is processed");
        }

        public override bool ValidatePaymentInfo()
        {
            return true;
        }

        public override bool ValidateShippingAddress()
        {
            return true;
        }
    }
}
