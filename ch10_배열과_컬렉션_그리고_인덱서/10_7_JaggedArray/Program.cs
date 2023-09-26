using System;

namespace JaggedArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr)
                    Console.Write($"{e} ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i=0; i<jagged.GetLength(0); i++)
            {
                var array = jagged[i];
                for (int j = 0; j < array.GetLength(0); j++)
                    Console.Write($"[{i}, {j}] : {array[j], -4} ");
                Console.WriteLine();
            }
        }
    }
}