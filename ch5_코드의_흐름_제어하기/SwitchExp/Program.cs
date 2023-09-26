using System;

namespace SwitchExp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요.");
            float.TryParse(Console.ReadLine(), out float score);

            Console.WriteLine("재수강인가요? (y/n)");
            string answer = Console.ReadLine();
            bool repeated = answer == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}");
        }
    }
}