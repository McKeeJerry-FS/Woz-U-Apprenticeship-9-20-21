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
    This Validation class holds static methods that are design to validate
    input that is entered by the user.
    */ 
    public static class Validation
    {
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

        // String Validation Method
        public static string StringValidation(string input)
        {
            // variable to store input
            string userInput = input;
            while (string.IsNullOrWhiteSpace(userInput))
            {
                // Tell user the error
                Console.WriteLine("\r\n Please do not leave this space blank.");
                // Reprompt
                Console.WriteLine(" Please type in a valid answer...");
                userInput = Console.ReadLine();
            }
            return userInput;

        }
        // end StringValidation()

        // Specific String Validation Method
        // This method checks to see if a user chooses a specific answer of [Y/N]
        public static string YesNoStringValidation(string input)
        {
            // variable to store input
            string userInput = input;
            while (string.IsNullOrWhiteSpace(userInput) && userInput != "Y" && userInput != "N")
            {
                // Tell user the error
                Console.WriteLine("\r\n Please do not leave this space blank.");
                // Reprompt
                Console.WriteLine(" Please type in a valid answer [Y/N]");
                userInput = Console.ReadLine();
            }
            return userInput;

        }
        // end YesNoStringValidation()

        // Range Validation
        // This method validates that a user has provided input that falls within the range
        // that is predetermined by the programmer.
        public static int RangeValidation(string userInputString, int minVal, int maxVal)
        {
            int userinput;
            while (!(int.TryParse(userInputString, out userinput)) || userinput < minVal || userinput > maxVal)
            {
                //Tell user the error
                Console.WriteLine("\r\n Invalid Entry");
                Console.WriteLine($" PLease type in a valid number between {minVal} and {maxVal}");
                userInputString = Console.ReadLine();
            }
            return userinput;
        }
        //end Range Validation
    }
}
