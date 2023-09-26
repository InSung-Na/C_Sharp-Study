using System;

namespace RelationalPattern
{
    internal class Program
    {
        static string GetGrade(double score) => score switch
        {
            < 60 => "F",
            < 70 => "D",
            < 80 => "C",
            < 90 => "B",
            _ => "A",
        };

        static void Main(string[] args)
        {
            Console.WriteLine(GetGrade(95.3));
        }
    }
}