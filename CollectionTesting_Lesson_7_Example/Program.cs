using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionTesting_Lesson_7_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] Strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            List<int> ListInts = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Dictionary<string, int> Str2Int = new Dictionary<string, int>() { { "zero", 0 }, { "one", 1}, { "two", 2},
                { "four", 4}, { "five", 5}, { "six", 6}, { "seven", 7}, { "eight", 8}, { "nine", 9} 
            };

            // Part 1
            IEnumerable iei = Ints;     // IEnumerable of ints
            IEnumerator ci = iei.GetEnumerator();
            

            Console.WriteLine(ci);
            bool value;
            while (true)
            {
                Console.Write(value = ci.MoveNext());
                if (!value) break;
                Console.WriteLine($" {ci.Current.GetType(), 20} {ci.Current}");
            }
            Console.WriteLine();

            // Part 2

            IEnumerable ies = Strings;
            IEnumerator cs = ies.GetEnumerator();
            Console.WriteLine(cs);

            while (true)
            {
                Console.Write(value = cs.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cs.Current.GetType(), 20} {cs.Current}");
            }
            Console.WriteLine();

            // Part 3
            IEnumerable ieL = ListInts;   //IEnumerable of ints
            IEnumerator cl = ieL.GetEnumerator();
            Console.WriteLine(cl);

            while (true)
            {
                Console.Write(value = cl.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cl.Current.GetType()} {cl.Current}");
            }
            Console.WriteLine();

            // Part 4
            IEnumerable ieD = Str2Int;
            IEnumerator cD = ieD.GetEnumerator();
            Console.WriteLine(cD);

            while (true)
            {
                Console.Write(value = cD.MoveNext());
                if (!value) break;
                Console.WriteLine($" {cD.Current.GetType()} {cD.Current}");
            }
            Console.WriteLine();

            //Part 5 - Looping over elements in an IDictionary
            IDictionary id = Str2Int;

            foreach (DictionaryEntry x in id)
            {
                Console.WriteLine($"Type: {x.GetType(),20} Key: {x.Key} Value: {x.Value} ");
            }


        }
    }
}
