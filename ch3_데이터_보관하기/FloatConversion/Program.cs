using System;

namespace FloatConversion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            double b = (double)a;
            Console.WriteLine($"{b} == {a} : {b == 69.6875}");

            float x = 0.1f;
            double y = (double)x;
            Console.WriteLine($"{y} == {x} : {y == 0.1}");
        }
    }
}