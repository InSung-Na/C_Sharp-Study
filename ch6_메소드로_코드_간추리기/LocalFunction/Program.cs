using System;

namespace LocalFunction
{
    internal class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i=0; i< arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)             //아스키코드를 활용한 문자변환
            {
                if (arr[i] < 65 || arr[i] > 90) //소문자 그대로 출력
                    return arr[i];
                else
                    return (char)(arr[i] + 32); //대문자 변환
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning"));
            Console.WriteLine(ToLowerString("This is C#!"));

        }
    }
}