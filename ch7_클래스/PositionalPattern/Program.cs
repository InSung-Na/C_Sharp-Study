using System;

namespace PosisionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }

        static void Main(string[] args)
        {
            var alice   = ("학생", 17);
            var bob     = ("학생", 23);
            var charlie = ("일반", 15);
            var dave    = ("일반", 21);

            Console.WriteLine($"alice\t: {GetDiscountRate(alice)}");
            Console.WriteLine($"bob\t: {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie\t: {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave\t: {GetDiscountRate(dave)}");
        }
    }
}