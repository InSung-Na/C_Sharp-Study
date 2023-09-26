using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //1바이트
            sbyte a = -10;
            byte b = 40;    //아스키코드를 문제준비해야 하므로 기본형이 unsigned

            Console.WriteLine($"a={a}, b={b}");

            // 2바이트
            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            // 4바이트
            int e = -1000_0000;
            uint f = 3_0000_0000;

            Console.WriteLine($"e = {e}, f = {f}");

            // 8바이트
            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}