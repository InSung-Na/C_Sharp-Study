using System;

namespace Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = null;

            Console.Write("데이터를 입력하세요. : ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i when i > 0:
                    Console.WriteLine($"{obj}는 양의 정수 형식입니다.");
                    break;
                case int i when i < 0:
                    Console.WriteLine($"{obj}는 음의 정수 형식입니다.");
                    break;
                case int i when i == 0:
                    Console.WriteLine($"{obj}는 정수 0 입니다.");
                    break;
                case float:
                    Console.WriteLine($"{obj}는 float 형식입니다");
                    break;
                default:
                    Console.WriteLine($"{obj}(은)는 {obj.GetType()} 입니다.");
                    break;
            }
        }
    }
}