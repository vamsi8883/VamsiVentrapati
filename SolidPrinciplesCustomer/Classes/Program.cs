using System;

namespace SolidPrinciplesCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerCollection cc =null;
            // cc= new TopNCustomers();
            // for(int i=0;i<10;i++)
            // {
            //     Customer obj = new Customer();
            //     cc.AddCustomer(obj);
            // }
       
            OrderProcessorOnline online = new OnlineOrder(new EmailSender());
            
            online.ProcessOrder();

        }
    }
}
