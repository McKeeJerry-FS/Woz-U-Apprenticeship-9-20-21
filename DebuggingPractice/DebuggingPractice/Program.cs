using System;

namespace Hypotenuse
{
    public class StudentProgram
    {
        static void Main(string[] args)
        {
            double x = Hypotenue(10, 20);
            Console.WriteLine(x);
        }
        public static double Hypotenue(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

    }
}
