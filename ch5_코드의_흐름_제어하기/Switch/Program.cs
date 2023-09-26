using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요. (일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                // 중략...
                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}