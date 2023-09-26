using System;
using static System.Console;

namespace StringFormatBasic
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // {IDX, 정렬과 공간 : 서식문자열}
            // IDX : 데이터 인덱스(위치)
            // - : 좌측정렬
            // + : 우측정렬
            // 서식문자열 : 10진, 16진, 콤마표기, 고정소수점, 지수표기
            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Lanugage");
            WriteLine();

            //서식문자열
            // D : 10진수
            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);

            // X : 16진수
            WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

            // N : 천단위 콤마
            WriteLine("콤마 : {0:N}", 123456789);
            WriteLine("콤마 : {0:N0}", 123456789);    // 자릿수 0은 소수점 이하를 제거

            // F : 고정 소수점
            WriteLine("고정 소수점 : {0:F}", 123.45);
            WriteLine("고정 소수점 ; {0:F5}", 123.345);

            // E : 지수표기
            WriteLine("지수표기 : {0:E}", 123.345);

        }
    }
}