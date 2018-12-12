
using System;

namespace SolidPrinciplesExample
{
    abstract class Employee :IBonusCalculation,IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //private FileLogger _fileLogger;
        //private EmailSender _emailsender;
        private ILogger _ilogger;
        public Employee()
        {
            
        }
        public Employee(int id,string name)
        {
            ID = id;
            Name = name;
           
           
          
         
        }
        public virtual decimal CalculateBonus(decimal salary)
        {
            return salary;
        }
        public void Notify(ILogger i,string message)
        {
            //if(_fileLogger == null && _emailsender == null)
            //{
            //    _emailsender = new EmailSender();
            //    _fileLogger = FileLogger.GetFileLoggerInstance();
            //}
            //_fileLogger.handler(message);
            //_emailsender.handler(message);
            i.handler(message);
           
          
        }
        public abstract decimal getMinimumsalary();
        
        //  public abstract decimal calculateBonus(decimal salary);
        

    }
}
