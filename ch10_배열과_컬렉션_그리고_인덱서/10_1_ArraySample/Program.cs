using System;

namespace ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;

            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}