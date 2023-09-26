using System;

namespace TypePattern
{
    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }

    internal class Program
    {
        static int CalculaterFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException(
                    $"Prohibited age: {visitor.GetType()}", nameof(visitor)),
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Fee for a senior: {CalculaterFee(new Senior())}");
            Console.WriteLine($"Fee for a adult: {CalculaterFee(new Adult())}");
            Console.WriteLine($"Fee for a underage: {CalculaterFee(new Underage())}");
            Console.WriteLine($"Fee for a preschooler: {CalculaterFee(new Preschooler())}");
        }
    }
}