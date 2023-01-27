using System;

namespace TestGit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resAdd, resMin;
            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Result: " + resAdd);
            resMin = a - b;
            Console.WriteLine("Result: " + resMin);
        }
    }
}
