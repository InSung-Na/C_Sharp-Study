using System;

namespace SwapByRef
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"Input : {x}, {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Output : {x}, {y}");
        }
    }
}