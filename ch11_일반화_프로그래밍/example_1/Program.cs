using System;
using System.Collections;
using System.Collections.Generic;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue("한글");
            que.Enqueue(10.23);

            while(que.Count > 0)
                Console.WriteLine(que.Dequeue());

            Queue<int> int_que = new Queue<int>();
            int_que.Enqueue(10);
            int_que.Enqueue("한글");
            int_que.Enqueue(10.23);

            while (int_que.Count > 0)
                Console.WriteLine(int_que.Dequeue());
        }
    }
}