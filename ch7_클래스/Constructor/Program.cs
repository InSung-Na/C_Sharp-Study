using System;

namespace Construcotr
{
    class Cat
    {
        //필드
        public string Name;
        public string Color;

        //생성자
        public Cat()
        {
            Name = "";
            Color = "";
        }
        //생성자 오버로딩
        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }
        //종료자
        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        //메서드
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}