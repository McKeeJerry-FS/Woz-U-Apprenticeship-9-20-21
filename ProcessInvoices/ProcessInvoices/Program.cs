using System;
using System.Collections.Generic;
using System.IO;

namespace ProcessInvoices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Date
            DateTime date;
            if (args.Length == 0)
            {
                date = DateTime.Now;
            }
            else if (args.Length != 1)
            {
                Console.WriteLine("Usage: This program expects to be provided a single date style(mm/dd/yyyy) command line argument");
                return;
            }
            else if (!DateTime.TryParse(args[0], out date))
            {
                Console.WriteLine($"Usage: The supplied parameter '{args[0]}' was not understood as a valid date");
                return;
            }
            Console.WriteLine($"Date for late computation: {date.ToShortDateString()}");
            
            // Load the Invoices.txt file 
            LoadFile();

            // Settup Results to print to the console

            // Compute the Late fees (if any)

            // Print all results to the console

        }

        static decimal ComputeLateFees(DateTime current, DateTime due, Decimal amount)
        {
            int numberOfDaysLate = (current - due).Days;
            if (numberOfDaysLate < 1)
            {
                return 0;
            }
            if (numberOfDaysLate < 8)
            {
                return amount * .1m;
            }
            numberOfDaysLate -= 7;
            return (amount * .1m) + numberOfDaysLate * .01m;
        }

        static void LoadFile()
        {
            // setting up variables that will hold the directory and file name 
            // string directory = "../../Properties";
            string filename = "../../../Invoices.txt";
            DateTime date;
            // The following block of code will setup a StreamReader to read data from the Invoice.txt file
            if (File.Exists(filename))
            { 
                // This sets up the StreamReader
                using (StreamReader stream = new StreamReader(filename))
                {
                    // This first line will read and consume the first single line from the file
                    stream.ReadLine();
                    string line;

                    // This loop is reading the data from Invoices.txt
                    while ((line = stream.ReadLine()) != null)
                    {
                        int invoiceNumber;
                        decimal bill;
                        DateTime invoiceDueDate;
                        string[] data = line.Split('|');

                        // checking to see if the first data string is an Integer, if it is, add it to the list
                        if (!int.TryParse(data[0], out invoiceNumber))
                        {
                            Console.WriteLine($"The line '{line}' is not valid. The first part must be an Integer");
                        }
                        
                        // checking to see if the data string is in date format; if it is, add it to the list
                        if (!DateTime.TryParse(data[1], out invoiceDueDate))
                        {
                            Console.WriteLine($"The line '{line}' is not valid. The second part must be a date.");
                        }

                        // checking to see if the third item is a decimal, if it is, add it to the list
                        if (!decimal.TryParse(data[2], out bill))
                        {
                            Console.WriteLine($"The line '{line}' is not valid. This part must be a decimal.");
                        }

                        date = DateTime.Now;
                        // This line of code will write out the results to the console
                        Console.WriteLine(value: $"Invoice Number: {invoiceNumber}; Invoice Due Date: {invoiceDueDate.ToShortDateString()}; Amount Due: ${bill,10}; Days Late: {(date - invoiceDueDate).Days,5}; Late Fee: ${ComputeLateFees(date, invoiceDueDate, bill):0.00}");
                    }



                }
            }


        }
    }
}
