using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    class TopNCustomers : CustomerCollection
    {
        int maxCount = 5;
        public override void AddCustomer(Customer obj)
        {
            if(Count < maxCount)
            {
               AddCustomer(obj);
            }
            else
            {
                throw new Exception("Only " + maxCount + " customers can be added.");
            }
        }
    }
    
}
