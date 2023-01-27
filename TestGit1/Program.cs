using System;

namespace TestGit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, resAdd, resMin, resSin, resCos;
            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Result: " + resAdd);
            resMin = a - b;
            Console.WriteLine("Result: " + resMin);
            resSin = Math.Sin(a+b);
            Console.WriteLine("Result: " + resSin);
            resCos = Math.Cos(a+b);
        }
    }
}
