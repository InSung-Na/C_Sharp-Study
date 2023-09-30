using System;

//문제 : 익명 메소드 -> 람다식
namespace Ex14_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            //원본
            //foreach(int a in array)
            //{
            //    Action action = new Action
            //        (
            //            delegate () { Console.WriteLine(a * a); }
            //        );
            //    action.Invoke();
            //}

            //풀이
            foreach (int a in array)
            {
                Action action = () => Console.WriteLine(a * a);
                action.Invoke();
            }
        }
    }
}