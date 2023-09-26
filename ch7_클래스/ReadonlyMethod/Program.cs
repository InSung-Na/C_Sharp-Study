using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32;   //읽기전용이므로 대입 불가능
            return target;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}