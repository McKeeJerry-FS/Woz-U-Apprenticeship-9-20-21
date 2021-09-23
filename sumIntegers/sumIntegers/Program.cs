using System;

namespace sumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in as many numbers as you like separated by spaces; Press ENTER when you are ready for the sum.");
            string input = Console.ReadLine();
            var individualStrings = input.Split(' ');
            int sum = 0;
            foreach (string s in individualStrings)
            {
                int userEntry;
                if (int.TryParse(s, out userEntry))
                {
                    sum += userEntry;
                    Console.WriteLine($"Accepted: {userEntry}, total is now {sum}");
                }
                else
                {
                    Console.WriteLine($"Rejected '{s}', invalid integer");
                }
            }
            Console.WriteLine($"The total final sum of acceptable integers is {sum}");
        }
    }
}
