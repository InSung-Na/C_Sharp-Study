using System;

namespace RelationalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 >  4\t: {3>4}");
            Console.WriteLine($"3 >= 4\t: {3>=4}");
            Console.WriteLine($"3 <  4\t: {3<4}");
            Console.WriteLine($"3 <= 4\t: {3<=4}");
            Console.WriteLine($"3 == 4\t: {3==4}");
            Console.WriteLine($"3 != 4\t: {3!=4}");
        }
    }
}