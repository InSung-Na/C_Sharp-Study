using System;

namespace String
{
    class MainApp
    {
        static void Main(string[] args)
        {
            char c = 'a';
            string s = "안녕하신가요?";
            string multiline = """
                첫번째 줄
                두버
                ㅇㄴㄹ
                ㄴㅇㄹ
                """;
            Console.WriteLine(c);
            Console.WriteLine(s);
            Console.WriteLine(multiline);
        }
    }
}