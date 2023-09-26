using System;

namespace ConstEnum
{
    internal class MainApp
    {
        // Enum : 수치 열거형
        enum DaysOfWeek
        { Sunday = 10, Monday, Tuesday, Wednesday = 20, Thursday, Friday, Saturday }

        static void Main(string[] args)
        {
            // const : 변경 불가능한 값
            const float pi = 3.141592f;
            Console.WriteLine(pi);

            // Enum 사용
            DaysOfWeek today = DaysOfWeek.Tuesday;
            Console.WriteLine((int)DaysOfWeek.Sunday);
            Console.WriteLine("오늘은 " + today + "입니다.");
        }
    }
}