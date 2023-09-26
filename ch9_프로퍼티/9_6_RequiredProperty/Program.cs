using System;

namespace RequiredProperty
{
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; set; }

        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo() { Name = "인성", Birthday = new DateTime(1998, 3, 23) };

            Console.WriteLine($"Name     : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday}");
            Console.WriteLine($"Age      : {birth.Age}");
        }
    }
}