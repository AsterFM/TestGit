using System;

namespace TestGit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, resAdd, resMin, resSqr;
            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Result: " + resAdd);
            resMin = a - b;
            Console.WriteLine("Result: " + resMin);
            resSqr = Math.Sqrt(a + b);
            Console.WriteLine("Result: " + resSqr);
        }
    }
}
