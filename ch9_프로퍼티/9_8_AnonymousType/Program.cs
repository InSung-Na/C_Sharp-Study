﻿using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "나인성", Age = 123 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.WriteLine($"Subject:{b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}