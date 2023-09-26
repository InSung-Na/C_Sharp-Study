using System;

namespace example
{
    class Fibonacci
    {
        public static long GetNumber(long index)
        {
            return index switch
            {
                0 => 0,
                1 => 1,
                _ => GetNumber(index - 1) + GetNumber(index - 2)
            };
        }
    }
    internal class Program
    {
        static void Problem1()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Problem2()
        {
            for(int i=5; i >= 1;i--)
            {
                for(int j=1; j <= i; j++)
                { Console.Write("*"); }
                Console.WriteLine();
            }
        }
        static void Problem3()
        {
            Console.Write("반복 횟수를 입력하세요. : ");
            int repeatCnt = int.Parse(Console.ReadLine());
            if (repeatCnt <= 0) { Console.WriteLine("0보다 같거나 작은 수는 사용할 수 없습니다."); return; }
            
            for (int i= 1; i<= repeatCnt; i++)
            {
                for(int j = 1; j <= i; j++) { Console.Write("*");}
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
            long result = Fibonacci.GetNumber(10);
            Console.WriteLine(result);
        }
    }
}