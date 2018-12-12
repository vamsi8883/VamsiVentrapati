using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesExample
{
    class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
                
        }
        public PermanentEmployee(int id, string Name) : base(id, Name)
        {
            
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal getMinimumsalary()
        {
            return 15000;
        }

        public override string ToString()
        {
            return ID + "  " + Name;
        }

      
    }
}
