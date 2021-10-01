using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Jerry McKee Jr.
10/01/2021
Woz-U Apprenticeship Training
Final Project for C# Core
*/

namespace finalProjectCSharp
{
    /*
    The UI Class  is built up with static methods that work through the
    UI design for the applications
    */ 
    public static class UI
    {
        // Header
        public static void Header(string text)
        {
            Console.WriteLine("=================================================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write($"{text.ToUpper()}\r\n");
            Console.ResetColor();
            Console.WriteLine("=================================================");
        }
        // end Header()


        // Separator
        public static void Separator()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----------------------");
            Console.ResetColor();
            Console.WriteLine("");
        }
        // end Seperator()

        // This method displays a small animation screen when
        // loading the menu.
        public static void Animation(string text)
        {

            // Creates a Loading animation on the Loading Screen
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(2, 5); i++)
            {
                Console.Clear();
                // Animation
                Console.Write($" {text} ");
                for (int dots = 0; dots < 7; dots++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(300);
                }
                // end Loading Animation

            }
            // end Random()
        }
        // end Loading()
    }
}
