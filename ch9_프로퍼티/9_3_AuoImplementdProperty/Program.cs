using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        //자동 프로퍼티 선언
        public string Name { get; set; } = "UnKnown";   //default값 설정
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1); //default값 설정
        public int Age
        {
            get
            {
                //(현재 시간 - 생일)의 년도 -> 현재 나이 반환
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
            Console.WriteLine();

            birth.Name = "인성";
            birth.Birthday = new DateTime(1998, 3, 23);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            Console.WriteLine("\nDateTime의 차이");
            Console.WriteLine($"DatTime.Now : {DateTime.Now.ToString()}");
            Console.WriteLine($"DatTime.Now : {birth.Birthday.ToString()}");
            Console.WriteLine($"DatTime.Now : {new DateTime(DateTime.Now.Subtract(birth.Birthday).Ticks)}");
        }
    }
}