﻿using System;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0, j = 0;
            T temp;

            for (i=0;i<DataSet.Length-1;i++)
            {
                for(j=0;j<DataSet.Length-(i+1);j++)
                {
                    if (Comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascedning...");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort<int>(array2, new Compare<int>(DescendCompare));
            foreach (int element in array2)
                Console.Write($"{element} ");

            string[] array3 = { "qwe", "rty", "yui", "asd" };
            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array3, new Compare<string>(DescendCompare));
            foreach (string element in array3)
                Console.Write($"{element} ");

            Console.WriteLine();
        }
    }

}