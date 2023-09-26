using System;
using static System.Console;

namespace StringModify
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());  //소문자화
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());  //대문자화

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));   //5번 인덱스에 문자추가
            WriteLine("Remove() : '{0}'", "I don't love you.".Remove(2, 6));  //2번 인덱스부터 6개 제거

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("Trim() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("Trim() : '{0}'", " No Spaces ".TrimEnd());
        }
    }
}