using System;
using System.Collections;
using System.Net.Http.Headers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace example_2
{
    class ArrayMultiply_2x2
    {
        // 배열 2x2 곱을 수행하는 메서드
        public static int[,] Multiply_2x2(int[,] array1, int[,] array2)
        {
            ValidateArraySize(array1, nameof(array1));
            ValidateArraySize(array2, nameof(array2));

            int[,] resultArray = new int[2, 2];

            resultArray[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
            resultArray[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
            resultArray[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
            resultArray[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];

            return resultArray;
        }

        // 2x2 사이즈를 검사하는 함수
        private static void ValidateArraySize(int[,] array, string arrayName)
        {
            if ((array.GetLength(0) != 2) || (array.GetLength(1) != 2))
            {
                throw new ArgumentOutOfRangeException(arrayName, "2x2 배열만 사용 가능합니다.");
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[,] { { 3, 2 }, { 1, 4 }, { 3, 3 } };
            int[,] arr2 = new int[,] { { 9, 2 }, { 1, 7 }, { 3, 3 } };

            int[,] result = ArrayMultiply_2x2.Multiply_2x2(arr1, arr2);

            for(int i=0;i<result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                    Console.Write($"{result[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}