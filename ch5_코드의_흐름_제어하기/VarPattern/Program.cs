using System;

namespace VarPattern
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var IsPassed =
                (int[] scores) => scores.Sum() / scores.Length is var average
                && Array.TrueForAll(scores, (score) => score >= 60)
                && average >= 60;

            int[] scores1 = { 90, 80, 60, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores1)}: Pass:{IsPassed(scores1)}");

            int[] scores2 = { 90, 80, 59, 80, 70 };
            Console.WriteLine($"{string.Join(",", scores2)}: Pass:{IsPassed(scores2)}");

        }
    }
}