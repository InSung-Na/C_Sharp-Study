using System;

namespace UsingParmas
{
    internal class Program
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");
            int result = 0;
            foreach (int arg in args)
            {
                result += arg;
                Console.Write($" {arg}");
            }
            Console.WriteLine();
            return result;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3,4,5,6);
            Console.WriteLine($"Sum : {sum}");
        }
    }
}