using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part1
{
    class Program
    {
         public static void Main()
        {
            do
            {
                try
                {
                    if (File.Exists("verbose.txt"))
                    {
                        var verbosereader = File.OpenText("verbose.txt");
                        string v = verbosereader.ReadLine();
                        bool test;
                        if (bool.TryParse(v, out test))
                        {
                            TaxCalculator.Verbose = test;
                        }
                        verbosereader.Dispose();
                    }
                    Console.WriteLine("Enter a state abbreviation");
                    string state = Console.ReadLine().ToUpper();
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

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
                Verbose = false;
                reader = File.OpenText("taxtable.csv");
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
        }

        public static decimal ComputeTaxFor(string state, decimal amountEarned)
        {
            List<TaxRecord> records;
            bool found = states.TryGetValue(state, out records);
            if (found)
            {
                Console.Write($"Found {records.Count} records for state: {state}");
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
                        return TotalTax = +thisBracket;

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

    class TaxRecord
    {
        public string StateCode { get; init; }
        public string State { get; init; }
        public decimal Floor { get; init; }

        public decimal Ceiling { get; init; }

        public decimal Rate { get; init; }

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
                throw new Exception($"item Ceiling:5th is not recognizable as a decimal['{items[4]}'] line=['{csv}']");
            }
        }
        public override string ToString()
        {
            return $"Tax Record for {StateCode} {State} Floor: {Floor,15:000000000.000} Ceiling:{Ceiling,15:000000000.000} Rate:{Rate:00.000000}";
        }

    }
}
