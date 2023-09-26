using System;
using System.Collections;
using static System.Console;

namespace InitializingCollcetions
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                WriteLine($"Queue : {item}");
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                WriteLine($"ArrayList2 : {item}");
            WriteLine();

            Hashtable hash = new Hashtable()
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3
            };
            
            foreach (object key in hash.Keys)
                Console.WriteLine($"키:{key}, 값:{hash[key]}");
            WriteLine();
        }
    }
}