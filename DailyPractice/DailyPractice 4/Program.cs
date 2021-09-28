using System;

namespace DailyPractice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Get two number
            Console.WriteLine("Type in a number");
            int userInput = IntegerValidation(Console.ReadLine());
            Console.WriteLine("Type in a number");
            int userInput2 = IntegerValidation(Console.ReadLine());
            // Add two numbers
            int sum = userInput + userInput2;
            Console.WriteLine(sum);
            
        }

        // Integer Validation Method
        public static int IntegerValidation(string input)
        {
            int userInput;
            while (!(int.TryParse(input, out userInput)))
            {
                //Tell the user the error
                Console.WriteLine("\r\n Invalid Entry");
                //Reprompt
                Console.WriteLine("Please type in a valid number.");
                //Recapture
                input = Console.ReadLine();
            }
            return userInput;
        }
        // end IntegerValidation()
    }
}
