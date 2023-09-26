using System;

namespace ParenthesizedPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object age = 30;
            if (age is (int and > 19 and < 65))
                Console.WriteLine("Major");
        }
    }
}