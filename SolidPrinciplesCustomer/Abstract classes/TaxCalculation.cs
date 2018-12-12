using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesCustomer
{
    abstract class TaxCalculation
    {
        //public decimal TaxCalculator(decimal amount, string country)
        //{
        //    decimal taxamount = 0;
        //    switch (country)
        //    {
        //        case "USA":
        //            break;
        //        case "India":
        //            break;
        //        default:
        //            break;
        //    }
        //    return taxamount;

        //}
        public abstract decimal TaxCalculator(decimal amount, string country);
    }
}
