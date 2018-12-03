using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class Customer:IDiscount,IDataBase
    {
        private ILogger _ilogger;
        private int _cuctType;
        public int _custType
        {
            get;set;
        }
        public Customer(ILogger logger)
        {
            _ilogger = logger;
        }
        //public double getDiscount(double Totalsales)
        //{
        //    if(_cuctType == 1)
        //    {
        //        return Totalsales - 100;
        //    }
        //    else
        //    {
        //        return Totalsales - 50;
        //    }
        //}
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
       
        public virtual void Add()
        {
            try
            {

            }
            catch(Exception exp)
            {
                _ilogger.handler(exp.ToString());
            }
        }
    }
    
}

