using System;

namespace PosisionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate((string job, int age) people)
        {
            switch (people)
            {
                case var (job, age) when job == "학생" && age < 18:
                    return 0.2;
                case var (job, age) when job == "학생":
                    return 0.1;
                case var (job, age) when job == "일반" && age < 18:
                    return 0.1;
                case var (job, age) when job == "일반":
                    return 0.05;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            var alice = ("학생", 17);
            var bob = ("학생", 23);
            var charlie = ("일반", 15);
            var dave = ("일반", 21);

            Console.WriteLine($"alice\t: {GetDiscountRate(alice)}");
            Console.WriteLine($"bob\t: {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie\t: {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave\t: {GetDiscountRate(dave)}");
        }
    }
}