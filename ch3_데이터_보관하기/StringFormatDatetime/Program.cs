using System;
using System.Globalization; // Globalization.CultureInfo
using static System.Console;

namespace StringformatDatetime
{
    class MainApp
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 09, 19, 17, 36, 22);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)}", ciKo));
            WriteLine(dt.ToString("yyy-MM-dd HH:mm:ss (dddd)}", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)}", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)}", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}