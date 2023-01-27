using System;

namespace TestGit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resAdd;
            Console.WriteLine("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Result: " + resAdd);
        }
    }
}
