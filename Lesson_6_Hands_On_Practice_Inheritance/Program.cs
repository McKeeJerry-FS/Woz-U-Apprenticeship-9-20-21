using System;

namespace Lesson_6_Hands_On_Practice_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an Engineer object
            Engineer engineer1 = new Engineer("Peter Parker", 48000, "May 6, 2016", "New York University");
            engineer1.getName();
            engineer1.getSalary();
            engineer1.hiredDate();

            Console.WriteLine("========================================================================");

            // Creating a software Engineer Object
            SoftwareEngineer softwareEngineer1 = new SoftwareEngineer("Tony Stark", 120000, "May 2, 2008", "Andover University");
            softwareEngineer1.getName();
            softwareEngineer1.getSalary();
            softwareEngineer1.hiredDate();
        }
    }
}
