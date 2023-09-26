using System;
using static System.Console;

namespace StringSlice
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good Moring  Nice to Meet you";

            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);

            WriteLine();
            string[] arr2 = greeting.Split(" ");
            foreach (string element in arr2)
                WriteLine("{0}", element);
        }
    }
}