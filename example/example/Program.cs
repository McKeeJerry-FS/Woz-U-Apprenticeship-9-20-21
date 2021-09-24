using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How are you?");
            string userAnswer = Console.ReadLine();
            Console.WriteLine($"You said you were {userAnswer}!");
            Console.WriteLine("That's great!!");
        }
    }
}
