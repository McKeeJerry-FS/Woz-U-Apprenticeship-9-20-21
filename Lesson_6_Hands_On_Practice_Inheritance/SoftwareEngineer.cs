using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Hands_On_Practice_Inheritance
{
    class SoftwareEngineer : Engineer
    {
        // Constructor that inherits properties from the Engineering class
        public SoftwareEngineer (string name, int salary, string hireDate, string schoolAttended) : base(name, salary, hireDate, schoolAttended)
        {
        }

        // Override Method to get the Employee's Salary
        public override void getSalary()
        {
            Console.WriteLine($"Salary: Sorry, this employee's salary is private.");
        }
    }
}
