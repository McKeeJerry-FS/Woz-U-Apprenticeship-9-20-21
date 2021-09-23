using System;


namespace Counting
{
    class Program
    {
        // entry point for the program
        static void Main(string[] args)
        {
            // running a conditional
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: This program expects to be provided a single integer command line argument");
                return;
            }
            int arg;
            // conditionals
            if (int.TryParse(args[0], out arg))
            {
                Console.WriteLine(CreateStrings(arg));
            }
            else
            {
                Console.WriteLine($"Usage: The suplied parameter '{args[0]}' was not a valid integer");
            }
        }

        static string CreateALine(int number)
        {
            string numberAsString = $"{number} ";
            // using a stringbuilder to create variable to hold text
            System.Text.StringBuilder sb = new System.Text.StringBuilder(50);
            // running a loop
            for (int i = 0; i < number; i++)
            {
                sb.Append(CreateALine(i));
                sb.Append('\n');
            }
            // returning a stringbuilder object as a string
            return sb.ToString();
        }

        static string CreateStrings(int count)
        {
            // using a stringbuilder to create variable to hold text
            System.Text.StringBuilder sb = new System.Text.StringBuilder(500);
            // running a loop 
            for (int i = 0; i <= count; i++)
            {
                sb.Append(CreateALine(i));
                sb.Append('\n');
            }
            // returning a stringbuilder object as a string
            return sb.ToString();
        }
    }
}
