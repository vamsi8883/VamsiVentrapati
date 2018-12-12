using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
   abstract class OrderProcessorOnline :OrderProcessCash
    {
        public abstract bool ValidatePaymentInfo();
        public abstract bool ValidateShippingAddress();
      
    }
}
