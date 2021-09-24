using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1ConceptPractice
{
    public static class UI
    {
        // Header
        public static void Header(string text)
        {
            Console.WriteLine("============================");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write($"{text.ToUpper()}\r\n");
            Console.ResetColor();
            Console.WriteLine("============================");
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
    }
}
