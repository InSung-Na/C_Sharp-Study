using System;
using System.Data;

namespace Method
{
    class Calculator
    {
        public int Plus(int a, int b)       // no static keyword
        {
            return a + b;
        }
        public static int Minus(int a, int b)   // use static keyword
        {
            return a - b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Plus(1, 2); // static 키워드가 없는 메소드 사용 시, 클래스 인스턴스를 생성 후 사용 가능
            Console.WriteLine(result);

            result = Calculator.Minus(1, 2);    // static 키워드가 있는 메소드 사용 시, 클래스에서 직접 사용 가능
            Console.WriteLine(result);
        }
    }
}