using System;
using System.Collections.Generic;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();
            list.Add(new SilverCustomer());
            list.Add(new GoldCustomer());
            //list.Add(new Enquiry());
            
        }
    }
}
