using System;

namespace Ex9_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine($"이름:{nameCard.Name}, 나이:{nameCard.Age}");

            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine($"Real:{complex.Real}, Imaginary:{complex.Imaginary}");
        }
    }
}