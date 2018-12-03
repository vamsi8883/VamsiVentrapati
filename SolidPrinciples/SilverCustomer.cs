using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) -50;
        }
    }
}
