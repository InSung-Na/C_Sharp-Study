using System;

namespace Overloading
{
    internal class Program
    {
        static int Plus(int a, int b) { return a + b; }
        static int Plus(int a, int b, int c) { return a + b + c; }
        static double Plus(int a, double b) { return a + b; }
        static double Plus(double a, double b) { return a + b; }


        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1, 2.1));
            Console.WriteLine(Plus(1.3, 2.4));
        }
    }
}