using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    internal class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", 1000.0);

            emp.setName("Nirosh");
            emp.setSalary(200000);

            Console.WriteLine("Name: "+ emp.getName() + 
                "\nCurrent Salary: " +emp.getSalary());

            emp.raiseSalary(10);
            Console.WriteLine("Deducted Tax: "+ emp.Tax());
            
            Console.ReadLine();
        }
    }
}
