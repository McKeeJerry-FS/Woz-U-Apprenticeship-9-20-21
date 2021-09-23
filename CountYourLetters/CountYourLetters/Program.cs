using System;
using System.Collections.Generic;

namespace CountYourLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            Console.WriteLine("Type in a phrase on a single line: ");
            string userInput = Console.ReadLine();

            foreach (char c in userInput)
            {
                char currentChar;
                currentChar = c;
                currentChar = char.ToUpper(c);

                int currrentNumber;

                if (counts.TryGetValue(currentChar, out currrentNumber))
                {
                    counts[currentChar] = currrentNumber + 1;
                    Console.WriteLine($"Already counted '{currentChar}', {currrentNumber} times, adding it once more.");
                }
                else
                {
                    counts.Add(currentChar, 1);
                    Console.WriteLine($"'{currentChar}' is new! Adding it to the list and setting it to 1!");
                }
            }

            Console.WriteLine("************** Counting is Complete!!!**********");
            foreach (var data in counts)
            {
                Console.WriteLine($"'{data.Key}' was found {data.Value} time(s)");
            }
        }
    }
}
