using System;

namespace DeclarationPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object foo = 23;
            if (foo is int bar)
                Console.WriteLine(bar);
        }
    }
}