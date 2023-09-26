using System;

namespace Slice
{
    class MainApp
    {
        /// <summary>
        /// 배열의 요소를 출력하는 메서드
        /// </summary>
        /// <param name="array"> 출력할 배열 </param>
        static void PrintArray(System.Array array)
            
        {
            foreach (var item in array)
                Console.Write(item);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //알파벳 배열 생성
            char[] array = new char['Z' - 'A' + 1]; //90 - 65 + 1 = 26 -> 알파벳 갯수
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);

            PrintArray(array[..]);  //알파벳 배열 전체
            PrintArray(array[5..]); //알파벳 배열 index 5 부터 출력

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);  //index 5부터 10미만까지

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);    //5번째부터 끝(^)까지

            PrintArray(array[^4..^1]);  //-4부터 -1 미만까지
        }
    }
}