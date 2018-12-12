using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    class SpecialCustomer :CustomerCollection
    {
        List<Customer> list = new List<Customer>();
        public override void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }
}
