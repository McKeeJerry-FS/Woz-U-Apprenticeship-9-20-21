using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using finalProjectCSharp;


/*
Jerry McKee Jr.
09/27/2021
Woz-U Apprenticeship Training
Final Project for C# Core
updated on 10/01/2021
*/

namespace finalProjectCSharp
{
    // Part 1
    class Program
    {
        public static void Main()
        {
            /*
            The Main() Method now opens a Main Menu for the user to choose
            which of the programs they would like to run. This menu will access
            the Tax Calculator Application and Print Employee Records (This application
            is still being built).
            */ 
             
            bool programRun = true;
            while (programRun)
            {
                // Call a menu to start the program
                List<string> menuItems = new List<string> { "Tax Calculator", "Print Out Employee List (Build InProgress)", };
                Menu menu = new Menu();
                menu.Init("Final Project For C# Core", menuItems);
                Console.WriteLine("Please choose from the list of options");
                int userChoice = Validation.RangeValidation(Console.ReadLine(), 0, menuItems.Count);
                switch (userChoice)
                {
                    case 1:
                        TaxCalcultorApp();
                        break;
                    case 2:
                        EmployeesList.PrintEmployeList();
                        break;
                    case 0:
                        Exit();
                        break;

                }
            }
            
            // This method is created to allow a user to exit the program.
            // By choosing Yes, the program will end; choosing No will
            // return the user to the Main Menu 
            void Exit()
            {
                programRun = true;
                UI.Header("Would you like to exit the program?");
                string userChoice = Validation.YesNoStringValidation(Console.ReadLine().ToUpper());
                if (userChoice == "Y")
                {
                    programRun = false;
                    Console.WriteLine("Thank You! Have a great day!");
                }
                
            }
        }

        // This method runs a program that reads through the
        // taxtable file and prints out the information
        // updated 09/01/2021:
        // * The program is now linked to a Main Menu. After 
        //   the records are printed out for the user, the 
        //   program returns to the Main Menu.
        public static void TaxCalcultorApp()
        {
            Console.Clear();
            UI.Header("Tax Calculator");
            try
            {
                if (File.Exists("../../verbose.txt"))
                {
                    var verbosereader = File.OpenText("../../verbose.txt");
                    string v = verbosereader.ReadLine();
                    bool test;
                    if (bool.TryParse(v, out test))
                    {
                        TaxCalculator.Verbose = test;
                    }
                    else
                    {
                        Console.WriteLine("There is an error");
                    }
                    verbosereader.Dispose();
                }
                Console.WriteLine("Enter a state abbreviation");
                string state = Validation.StringValidation(Console.ReadLine().ToUpper());
                Console.WriteLine("Enter an income");
                string line;
                decimal income;
                while (!decimal.TryParse(line = Console.ReadLine(), out income))
                {
                    Console.WriteLine("Income was not recognized as a decimal...");
                    Console.WriteLine("Please Enter an income as a decimal");
                }

                decimal tax = TaxCalculator.ComputeTaxFor(state, income);
                Console.WriteLine(tax);
                Console.WriteLine("Press enter to continue");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
    

static class TaxCalculator
{
    // create a dictionary
    static Dictionary<string, List<TaxRecord>> states;
    // create a static constructor
    static TaxCalculator()
    {
        StreamReader reader = null;
        try
        {
            states = new Dictionary<string, List<TaxRecord>>();
            Verbose = true;
            reader = File.OpenText("../../../taxtable.csv");
            string line;
            do
            {
                line = reader.ReadLine();
                try
                {
                    TaxRecord r = new TaxRecord(line);
                    List<TaxRecord> records;
                    bool found = states.TryGetValue(r.StateCode, out records);
                    if (found)
                    {
                        records.Add(r);
                    }
                    else
                    {
                        records = new List<TaxRecord>();
                        records.Add(r);
                        states.Add(r.StateCode, records);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Continuing...");
                }
            }
            while (!reader.EndOfStream);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Trying to continue....");
        }
    }

    public static bool Verbose;
    static void VWrite(string s)
    {
        if (Verbose)
        {
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine("There is an error");
        }
    }

    public static decimal ComputeTaxFor(string state, decimal amountEarned)
    {
        List<TaxRecord> records;
        
        bool found = states.TryGetValue(state, out records);

        if (found)
        {
            VWrite($"Found {records.Count} records for state: {state}");
            decimal TotalTax = 0M;
            foreach (TaxRecord r in records)
            {
                if (amountEarned >= r.Floor && amountEarned <= r.Ceiling)
                {
                    decimal incomeForThisBracket = amountEarned - r.Floor;
                    decimal thisBracket = incomeForThisBracket * r.Rate;
                    VWrite($"Found Record {r} thisBracket : thisBracket: [income: {incomeForThisBracket} Tax: {thisBracket}] Total Tax So Far: {TotalTax}");
                    return TotalTax + (amountEarned - r.Floor) * r.Rate;
                }
                else
                {
                    decimal incomeForThisBracket = amountEarned - r.Floor;
                    decimal thisBracket = incomeForThisBracket * r.Rate;

                    VWrite($"Found Record {r} thisBracket : thisBracket: [income: {incomeForThisBracket} Tax: {thisBracket}]   Total Tax Computed: {TotalTax}");
                    TotalTax = +thisBracket;

                }
            }
            throw new Exception($"Income was higher than the tax ceiling: {amountEarned}");
        }
        else
        {
            throw new Exception("There was an error!!");
        }

    }
}
// This method builds each of the Tax records to be added
// to the list in the Tax Calculator
class TaxRecord
{
    public string StateCode { get; init; }
    public string State { get; init; }
    public decimal Floor { get; init; }

    public decimal Ceiling { get; init; }

    public decimal Rate { get; init; }
    public decimal YearlyPay { get; }

    public TaxRecord(string csv)
    {
        string[] items = csv.Split(',');
        // checking for "5" elements
        if (items.Length != 5)
        {
            throw new Exception($"csv does not have exactly 5 fields separated byy commas (it has {items.Length}) ['{csv}']");
        }

        // assigning StateCode
        StateCode = items[0];

        // assigning State
        State = items[1];

        // setting up Floor variable
        decimal a;
        if (decimal.TryParse(items[2], out a))
        {
            Floor = a;
        }
        else
        {
            throw new Exception($"item Floor:3rd is not recognizable as a decimal ['{items[2]}'] line=['{csv}']");
        }

        // Setting up Ceiling variable
        decimal b;
        if (decimal.TryParse(items[3], out b))
        {
            Ceiling = b;
        }
        else
        {
            throw new Exception($"item Ceiling:4th is not recognizable as a decimal['{items[3]}'] line=['{csv}']");
        }

        // setting up rate
        decimal c;
        if (decimal.TryParse(items[4], out c))
        {
            Rate = c;
        }
        else
        {

            throw new Exception($"item Ceiling:5th is not recognizable as a decimal['{items[4]}'] line=['{csv}']");
        }
    }
    public override string ToString()
    {
        return $"Tax Record for {StateCode} {State,20} Floor: {Floor,15:000000000.000} Ceiling:{Ceiling,15:000000000.000} Rate:{Rate:00.000000}";
    }

}

//Part 2
class EmployeeRecord
{
    //    ID                        a number to identify an employee
    //    Name                      the employee name
    //    StateCode                 the state collecting taxes for this employee
    //    HoursWorkedInTheYear      the total number of hours worked in the entire year (including fractions of an hour)
    //    HourlyRate                the rate the employee is paid for each hour worked
    //                                  assume no changes to the rate throughout the year.
    public int Id { get; set; }
    public string Name { get; set; }
    public string StateCode { get; set; }
    public decimal HoursWorkedInTheYear { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal YearlyPay { get; }
    public decimal TotalTaxDue { get; }

    //    provide a constructor that takes a csv and initializes the employeerecord
    //       do all error checking and throw appropriate exceptions

    public EmployeeRecord(string csv)
    {
        string[] items = csv.Split(',');
        StreamReader reader = null;
        try
        {
           
            reader = File.OpenText(csv);
            string line;
            if (items.Length != 5)
            {
                throw new Exception($"Invalid number of items in csv string: Expecting 5, found: {items.Length}");
            }
            int id;
            if (int.TryParse(items[0], out id))
            {
                Id = id;
            }
            else
            {
                throw new Exception($"Invalid ID, not an integer: '{items[0]}' in csv '{csv}'");
            }
            Name = items[1];
            StateCode = items[2];
            decimal hours;
            if (decimal.TryParse(items[3], out hours))
            {
                HoursWorkedInTheYear = hours;
            }
            else
            {
                throw new Exception($"Invalid HoursWorkedInAYear, not a double: '{items[3]}' in csv '{csv}'");
            }
            decimal rate;
            if (decimal.TryParse(items[4], out rate))
            {
                HourlyRate = rate;
            }
            else
            {
                throw new Exception($"Invalid HourlyRate, not a decimal: '{items[4]}' in csv '{csv}'");
            }
            decimal YearlyPay = decimal.Round(rate * hours);
            decimal TotalTaxDue = TaxCalculator.ComputeTaxFor(StateCode, YearlyPay);
            
           
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Trying to continue....");
        }
    }
    public override string ToString()
    {
        return $"Tax Information for Employee: {Name}: Yearly Pay: {YearlyPay,5} Total Tax Due: {TotalTaxDue,5}";
    }

    
}

static class EmployeesList
{
    // create an EmployeeList class that will read all the employees form the Employees.csv file
    // the logic is similar to the way the taxcalculator read its taxrecords
    static List<EmployeeRecord> employees;
    public static List<EmployeeRecord> Employees { get { return employees; } }
    // Create a List of employee records.  The employees are arranged into a LIST not a DICTIONARY
    //   because we are not accessing the employees by state,  we are accessing the employees sequentially as a list
    static EmployeesList()
    {
        string csv = "../../../employees.csv";
        StreamReader reader = null;
        try
        {
            employees = new List<EmployeeRecord>();
            reader = File.OpenText(csv);
            string line;
            do
            {
                line = reader.ReadLine();
                try
                {
                    EmployeeRecord employee = new EmployeeRecord(line);
                    employees.Add(employee);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Continue");
                }
            }
            while (!reader.EndOfStream);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Trying to continue");
        }

    }
    
    // create a static constructor to load the list from the file
    //   be sure to include try/catch to display messages
    public static void PrintEmployeList()
    {
        for(int i = 0; i < employees.Count; i++)
        {
            employees[i].ToString();
        }
        UI.Header("Press any key to return to the Main Menu");
        Console.ReadKey();
    }
}


