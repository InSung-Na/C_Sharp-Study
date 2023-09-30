using System;

namespace StatementLambda
{
    class MainApp
    {
        public delegate string Concatenate(string[] args);

        static string GetSumString(string[] arr)    //단순 함수로 구현
        {
            string result = "";
            foreach (string s in arr)
                result += s;
            return result;
        }

        static void Main(string[] args)
        {
            Concatenate concat = (arr) =>           //대리자(delegate)를 사용한 문 형식의 람다식
            {
                string result = "";
                foreach (string s in arr)
                    result += s;

                return result;
            };

            Console.WriteLine(concat(args));
            Console.WriteLine(GetSumString(args));
        }


    }
}