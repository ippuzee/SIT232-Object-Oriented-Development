using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProgram
{
    internal class Employee
    {
        private string name;
        private double salary;

        public Employee(string employeename, double currentsalary)
        {
            this.name = employeename;
            this.salary = currentsalary;
        }

        public string getName()
        {
            return this.name;
        }

        public string getSalary()
        {
            return this.salary.ToString("C");
        }

        public void raiseSalary(double pct_increment)
        {
            double pct = ((100 + pct_increment) / 100);
            this.salary *= pct;
            Console.WriteLine("Updated Salary: " + getSalary());
        }

        public void setName(string name)
        {
            this.name = name; 
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double Tax()
        {
            if (this.salary <= 18200)
            {
                return 0;
            }

            else if (this.salary <= 37000)
            {
                double tax = ((this.salary - 18200) * 0.19);
                return tax;
            }
            
            else if (this.salary <= 90000)
            {
                double tax = (3572 + ((this.salary - 37000) * 0.325));
                return tax;
            }

            else if (this.salary <=180000)
            {
                double tax = (20797 + ((this.salary - 90000) * 0.37));
                return tax;
            }

            else 
            {
                double tax = (54096 + ((this.salary - 180000) * 0.45));
                return tax;
            }

        }
    }
}
