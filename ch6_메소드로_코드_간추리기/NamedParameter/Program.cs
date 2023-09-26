using System;

namespace NamedParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"name : {name}, phone : {phone}");
        }
        static void PrintProfile2(string name, string phone="")
        {
            Console.WriteLine($"name : {name}, phone : {phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박차호", phone: "010-1234-3456");
            PrintProfile(phone: "010-1234-3456", name: "박차호");
            PrintProfile("깆ㄴㅇ", "-112312312312");

            Console.WriteLine();
            PrintProfile2("중근");
            PrintProfile2("곽중", "0101-23123-12141");
        }
    }
}