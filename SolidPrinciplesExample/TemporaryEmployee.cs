using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesExample
{
    class TemporaryEmployee : Employee,IEmployee
    {
        public TemporaryEmployee()
        {

        }
        public TemporaryEmployee(int Id,string Name):base(Id,Name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal getMinimumsalary()
        {
            return 10000;
        }
       

    }
}
