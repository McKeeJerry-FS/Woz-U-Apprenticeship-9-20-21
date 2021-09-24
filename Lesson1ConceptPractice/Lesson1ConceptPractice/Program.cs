using System;

namespace Lesson1ConceptPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Good morning, {name}!");
            AddTwoNumber();
            UI.Separator();
            PrintFullName();
            UI.Separator();
            NameAndAge();
            UI.Separator();
            CanBuyCigarettes();
            UI.Separator();
            Console.WriteLine($"Great job, {name}! Have a great day!");

        }

        static void AddTwoNumber()
        {
            UI.Header("Add Two Numbers");
            Console.WriteLine("Let's add 2 numbers.");
            Console.WriteLine("Enter the first number...");
            string userInput1String = Console.ReadLine();
            int userInput1 = Convert.ToInt32(userInput1String);
            Console.WriteLine("Enter the first number...");
            string userInput2String = Console.ReadLine();
            int userInput2 = Convert.ToInt32(userInput2String);
            UI.Separator();
            int sumOfNumbers = userInput1 + userInput2;
            Console.WriteLine($"The sum of {userInput1} and {userInput2} is: {sumOfNumbers}");
        }

        static void PrintFullName()
        {
            UI.Header("Print Your Full Name");
            string firstName = "Jerry";
            string lastName = "McKee";
            string suffix = "Jr.";
            UI.Separator();
            Console.WriteLine($"Your full name is {firstName} {lastName} {suffix}.");
        }

        static void NameAndAge()
        {
            UI.Header("Get Your Name and Age");
            Console.WriteLine("Ok, here's the next thing we'll do today. Let's get your full name again.");
            Console.WriteLine("Go ahead and enter your full name.");
            string fullName = Console.ReadLine();
            Console.WriteLine($"Alright {fullName}, what is your age?");
            string userAgeString = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeString);
            Console.WriteLine();
            UI.Separator();
            Console.WriteLine($"OK. So your name is {fullName} and your age is {userAge}.");

        }

        static void CanBuyCigarettes()
        {
            UI.Header("Can you buy cigarettes?");
            Console.WriteLine("Let's see if you can buy cigarettes.");
            Console.WriteLine("What was your age again?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So you are {userAge} years old.");
            UI.Separator();
            if (userAge > 21)
            {
                Console.WriteLine($"Your are {userAge} years old. You can buy cigarettes.");
            }
            else
            {
                Console.WriteLine($"You are {userAge} years old. You cannot buy cigarettes.");
            }
        }
    }
}
