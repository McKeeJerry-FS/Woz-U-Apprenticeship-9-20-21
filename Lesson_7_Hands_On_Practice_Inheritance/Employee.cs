using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_Hands_On_Practice_Inheritance
{
    class Employee
    {
        // class fields
        string name;
        int salary;
        string hireDate;
        
        // Constructor
        public Employee(string name, int salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        
        // Virtual Method to get Employee's Name
        public virtual void getName()
        {
            Console.WriteLine($"Employee Name: {this.name}");
        }

        // Virtual Method to get Employee's Salary
        public virtual void getSalary()
        {
            Console.WriteLine($"Salary: {this.salary}");
        }

        // Virtual Method to get Employee's Hired Date
        public virtual void hiredDate()
        {
            Console.WriteLine($"Hire Date: {this.hireDate}");
        }
            
    }
}
