using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Hands_On_Practice_Inheritance
{
    class Engineer : Employee
    {
        // class field
        string schoolAttended;

        // constructor that inherits properties from the Employee class
        public Engineer(string name, int salary, string hireDate, string schoolAttened) : base(name, salary, hireDate)
        {
            this.schoolAttended = schoolAttended;
        }
    }
}
