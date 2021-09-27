using System;

namespace CodingPracticeAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            Console.WriteLine();
            Console.WriteLine("=============================");
            ArithmeticOperations();
            Console.WriteLine();
            Console.WriteLine("=============================");
            FindLargestNumber();
            Console.WriteLine();
            Console.WriteLine("=============================");
            CheckLeapYear();
            Console.WriteLine();
            Console.WriteLine("=============================");
            CheckUpperLowerCase();
            Console.WriteLine();
            Console.WriteLine("=============================");
            PrintDayOfWeek();

        }

        // This program shows all arithmetic operations
        public static void ArithmeticOperations()
        {
            Console.WriteLine("Please input the first number.");
            string num1String = Console.ReadLine();
            int num1 = Convert.ToInt32(num1String);
            Console.WriteLine("Please enter in a second number.");
            string num2String = Console.ReadLine();
            int num2 = Convert.ToInt32(num2String);
            Console.WriteLine();
            Console.WriteLine("=============================");
            int answerAddition = num1 + num2;
            Console.WriteLine($"The sum of {num1} and  {num2} is {answerAddition}");
            int answerSubtraction = num1 - num2;
            Console.WriteLine($"The difference of {num1} and  {num2} is {answerSubtraction}");
            int answerProduct = num1 * num2;
            Console.WriteLine($"The product of {num1} and  {num2} is {answerProduct}");
            int answerDividend = num1 / num2;
            Console.WriteLine($"The dividend of {num1} and  {num2} is {answerDividend}");
            int answerRemainder = num1 % num2;
            Console.WriteLine($"The remainder of {num1} divided by  {num2} is {answerRemainder}");
        }

        public static void FindLargestNumber()
        {
            Console.WriteLine("Here, we are looking for the largest of three numbers.");
            Console.WriteLine("Please input the first number.");
            string num1String = Console.ReadLine();
            int num1 = Convert.ToInt32(num1String);
            Console.WriteLine("Please enter in a second number.");
            string num2String = Console.ReadLine();
            int num2 = Convert.ToInt32(num2String);
            Console.WriteLine("Please enter in a third number.");
            string num3String = Console.ReadLine();
            int num3 = Convert.ToInt32(num3String);
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the largest");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"{num2} is the largest");
            }
            else
            {
                Console.WriteLine($"{num3} is the largest");
            }

        }

        public static void CheckLeapYear()
        {
            Console.WriteLine("What is the date you would like to check for a leap year?");
            string dateString = Console.ReadLine();
            int year = Convert.ToInt32(dateString);

            bool isLeapYear = false;
            if (year % 400 == 0)
            {
                isLeapYear = true;
               
            }
            else if (year % 100 == 0)
            {
                isLeapYear = false;
            }
            else if (year % 4 == 0)
            {
                isLeapYear = true;
            }

            if (isLeapYear == true )
            {
                Console.WriteLine($"{year} is a leap year!");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year!");
            }

        }

        public static void CheckUpperLowerCase()
        {
            Console.WriteLine("Enter in a letter");
            char userChar = Convert.ToChar(Console.ReadLine());
            bool result = Char.IsUpper(userChar);
            if (result)
            {
                Console.WriteLine($"Character {userChar} is Uppercase");
            }
            else
            {
                Console.WriteLine($"Character {userChar} is Lowercase");
            }
        }

        public static void PrintDayOfWeek()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dddd"));

        }
    }
}
