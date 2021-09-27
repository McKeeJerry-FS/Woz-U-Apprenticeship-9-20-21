using System;
using System.Collections.Generic;


namespace HandsOnPracticeProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Project 1

            Sale s1 = new Sale("One", 1000, .10M);
            Sale s2 = new Sale("One", 500, .05M);
            Sale s3 = new Sale("Two", 2500, .10M);
            Sale s4 = new Sale("Two", 3000);
            Sale s5 = new Sale("One", 1500, .083M);
            Sale s6 = new Sale("Two", 5500, .062M);

            try
            {
                Console.WriteLine($"Employee: {s1.Employee, 10}   Sales: {s1.SalesAmount, 15}   Commission: {s1.Commission, 10}");
                Console.WriteLine($"Employee: {s2.Employee, 10}   Sales: {s2.SalesAmount, 15}   Commission: {s2.Commission, 10}");
                Console.WriteLine($"Employee: {s3.Employee, 10}   Sales: {s3.SalesAmount, 15}   Commission: {s3.Commission, 10}");
                Console.WriteLine($"Employee: {s4.Employee, 10}   Sales: {s4.SalesAmount, 15}   Commission: {s4.Commission, 10}");
                Console.WriteLine($"Employee: {s5.Employee, 10}   Sales: {s5.SalesAmount, 15}   Commission: {s5.Commission, 10}");
                Console.WriteLine($"Employee: {s6.Employee, 10}   Sales: {s6.SalesAmount, 15}   Commission: {s6.Commission, 10}");
                Console.WriteLine("=============================================================================================");
                // Console.WriteLine(SalesTotal(s1.SalesAmount, s1.Employee, s2.SalesAmount, s2.Employee));
                // Console.WriteLine(SalesTotal(s3.SalesAmount, s3.Employee, s4.SalesAmount, s4.Employee));
                // Console.WriteLine(SalesTotal(s2.SalesAmount, s2.Employee, s3.SalesAmount, s3.Employee));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Project 2

            // This code block reads a test file that you will need to create
            // To create a text file:
            // Right-click on the project name
            // hover over add
            // click on "New Item"
            // On the left hand side of the box, choose "General"; select "Text File" from the list; name your text file and click "Add"
            // Add the information from the project outline to the text file and save it


            // This line of code reads from the text file you created
            System.IO.TextReader reader = System.IO.File.OpenText("../../../sales.txt");
            string line;
            // creating a new list
            List<Sale> salesData = new List<Sale>();
            
            // The while statement reads through the file and adds the line to your list
            while (!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
            {
                try
                {
                    salesData.Add(new Sale(line));
                }
                // this line will throw an exception if the line is not readable
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // this closes the reader
            reader.Close();

            // This code block prints the list to the console
            for (int i = 0; i < salesData.Count; i++)
            {
                Console.WriteLine($"{i,3}: {salesData[i]}");
                
            }
            Console.WriteLine($"*********************************************************************************************");
            while (true) ;
            

            

        }
        /*
        public static string SalesTotal(decimal a, string employeeA, decimal b, string employeeB)
        {
            Sale s1 = new Sale("One", 1000, .10M);
            Sale s2 = new Sale("One", 500, .05M);
            Sale s3 = new Sale("Two", 2500, .10M);
            Sale s4 = new Sale("Two", 3000);
            Sale s5 = new Sale("One", 1500, .083M);
            Sale s6 = new Sale("Two", 5500, .062M);

            string message = "";
            if (employeeA == employeeB)
            {
                decimal salesAmountSum = a + b;
                message = salesAmountSum.ToString();
            }
            else
            {
                message = "Can only add sale objects if the employee is the same. In this case left = \"One\" and Right = \"Two\"";
            }

            return message;
        }
        */

        
        


    }

}
