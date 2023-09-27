using System;

namespace Ex12_1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[10];
                for (int i = 0; i < 10; i++)
                    arr[i] = i;

                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("코드가 종료되었습니다.");
            }
        }
    }
}