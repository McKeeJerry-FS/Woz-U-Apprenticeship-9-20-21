using System;

namespace EmployeePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Integer: ");
            string firstIntegerString = Console.ReadLine();
            int firstInteger = Convert.ToInt32(firstIntegerString);
            Console.WriteLine("Enter the Second Integer: ");
            string secondIntegerString = Console.ReadLine();
            int secondInteger = Convert.ToInt32(secondIntegerString);
            int sumOfIntegers = firstInteger + secondInteger;
            Console.WriteLine("The sum of " + firstInteger + " + " + secondInteger + " = " + sumOfIntegers);
        }
    }
}
