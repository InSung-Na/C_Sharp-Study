using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birthday = new BirthdayInfo()
            {
                Name = "인성",
                Birthday = new DateTime(1998, 3, 23)
            };

            Console.WriteLine($"Name : {birthday.Name}");
            Console.WriteLine($"Birthday : {birthday.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birthday.Age}");
        }
    }
}