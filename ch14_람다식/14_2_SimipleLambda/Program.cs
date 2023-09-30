using System;

namespace SimpleLambda
{
    class MainApp
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate cal = (a, b) => a + b;        // 람다식
            //Calculate calc = delegate (int a, int b) { return a + b; }; // 대리자-익명메소드

            Console.WriteLine($"{3} + {4} = {cal(3, 4)}");
        }
    }
}