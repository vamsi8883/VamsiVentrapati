using System;
using System.Collections.Generic;
namespace SolidPrinciplesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee Empvam = new PermanentEmployee(1, "vamsi");
            //Employee EmpKri = new TemporaryEmployee(2, "Krishna");
            //Console.WriteLine(string.Format("Employee : {0} ,Bonus : {1}" ,Empvam.ToString(),Empvam.calculateBonus(10000).ToString()));
            //Console.Read();
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "vamsi"));
            employees.Add(new TemporaryEmployee(2, "Krishna"));
            //employees.Add(new ContractEmployee());
            EmailSender sender = new EmailSender();
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.CalculateBonus(10000));
                emp.Notify(sender,"Operation is successfull");
                
                
            }
            
            //List<IEmployee> Iemployees = new List<IEmployee>();
            //Iemployees.Add(new PermanentEmployee(1, "vamsi"));
            //Iemployees.Add(new TemporaryEmployee(2, "Krishna"));
            //foreach (var employee in Iemployees)
            //{
            //    Console.WriteLine(employee.getMinimumsalary());
                
            //}

        }
    }
}
