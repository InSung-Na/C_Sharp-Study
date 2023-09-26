using System;

namespace IncDecOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); //post-increment operator
            Console.WriteLine(++a); //pre-increment operator
            Console.WriteLine(a--); //post-decrement operator
            Console.WriteLine(--a); //pre-decrement operator
        }
    }
}