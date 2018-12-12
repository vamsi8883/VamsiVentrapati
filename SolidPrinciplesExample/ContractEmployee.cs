using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesExample
{
    class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal getMinimumsalary()
        {
            return 7500;
        }
    }
}
