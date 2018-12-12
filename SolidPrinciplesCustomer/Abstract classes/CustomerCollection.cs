using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    abstract class CustomerCollection
    {
        public abstract void AddCustomer(Customer obj);
        public  int Count { get; set; }
    }
}
