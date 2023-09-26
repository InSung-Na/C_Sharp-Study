using System;

namespace Return
{
    class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("알고 싶은 피보나치 수를 입력하시오 : ");
            Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine())));
        }
    }
}