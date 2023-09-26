using System;
using System.Runtime.CompilerServices;

namespace PositionalPattern
{
    struct Audience
    {
        private bool IsCitizen { get; init; }
        private int Age { get; set; }

        public Audience(bool isCitizen, int age)
        {
            IsCitizen = isCitizen;
            Age = age;
        }

        public void Deconstruct(out bool isCitizen, out int age)
        {
            isCitizen = IsCitizen;
            age = Age;
        }

        public bool GetIsCitizen()
        {
            return IsCitizen;
        }
        public int GetAge()
        {
            return Age;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            var CalculateFee = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            Console.WriteLine($"내국인: {a1.GetIsCitizen()}\t 요금: {a1.GetAge()}");

            var a2 = new Audience(false, 33);
            Console.WriteLine($"내국인: {a2.GetIsCitizen()}\t 요금: {a2.GetAge()}");
        }
    }
}