using System;

namespace example
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int squareArea = Convert.ToInt32(width) * Convert.ToInt32(height);
            Console.WriteLine("사각형의 넓이는 : {0}", squareArea);
        }
    }
}