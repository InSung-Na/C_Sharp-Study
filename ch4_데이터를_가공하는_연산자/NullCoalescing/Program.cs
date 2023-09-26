using System;

namespace NullCoalescing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");

            num = 99;
            Console.WriteLine(num.HasValue ? num.Value : 0);

            string str = null;
            Console.WriteLine(str is not null ? str : "Default");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}