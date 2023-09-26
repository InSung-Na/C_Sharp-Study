using System;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오. : ");

            string input = Console.ReadLine();
            int number = 0;
            //Int32.TryParse(input, out number);  // number = Int.Parse ? input : 0
            try { number = Convert.ToInt32(input); }
            catch (FormatException) { Console.WriteLine("오류! 정수만 입력하세요."); return; }
            Console.WriteLine(number.ToString());
            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else Console.WriteLine("0");

            if (number % 2 == 0) Console.WriteLine("짝수");
            else Console.WriteLine("홀수");

        }
    }
}