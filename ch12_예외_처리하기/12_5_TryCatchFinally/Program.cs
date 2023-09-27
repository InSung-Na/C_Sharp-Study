using System;

namespace Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("피제수를 입력하세요. : ");
                int dividend = Convert.ToInt32(Console.ReadLine());

                Console.Write("제수를 입력하세요. : ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"에러 : {e.Message}");
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}