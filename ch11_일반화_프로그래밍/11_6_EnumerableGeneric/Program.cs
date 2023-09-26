using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;
        public MyList() //배열 사용 설정
        {
            array = new T[3];
        }

        public T this[int index]    //indexer 설정
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)  //배열 크기 늘리기
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;   //배열에 값 추가하기
            }
        }

        public int Length { get { return array.Length; } }

        public IEnumerator<T> GetEnumerator() { return this; }
        IEnumerator IEnumerable.GetEnumerator() { return this; }

        public T Current { get { return array[position]; } }
        object IEnumerator.Current => array[position];

        public bool MoveNext()
        {
            if(position == array.Length -1)
            {
                Reset();
                return false;
            }

            position++;
            return(position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                Console.WriteLine(str);
        }
    }
}