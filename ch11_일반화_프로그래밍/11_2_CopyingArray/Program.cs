﻿using System;

namespace CopyingArray
{
    class MainApp
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int element in target)
                Console.WriteLine(element);
            Console.WriteLine();

            string[] source2 = { "하나", "둘", "셋", "넷" };
            string[] target2 = new string[source.Length];

            CopyArray<string>(source2, target2);

            foreach (string element in target2)
                Console.WriteLine(element);
        }
    }
}