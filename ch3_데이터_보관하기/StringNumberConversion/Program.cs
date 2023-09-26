using System;

namespace StringNumberConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 수치를 문자열로
            // numVar.ToString()
            int a = 123;
            string b = a.ToString();

            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            // 문자를 수치로
            // Convert.DTYPE(TEXT)
            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.1234";
            float h = Convert.ToSingle(g);
            Console.WriteLine(h);
        }
    }
}