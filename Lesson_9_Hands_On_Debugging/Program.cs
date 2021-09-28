using System;

namespace lesson9HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 7, 29, 43, 12, 20, 88, 121 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
