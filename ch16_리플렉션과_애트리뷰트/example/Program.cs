using System;

namespace Ex16_1_2
{
    class Car
    {
        public int price;
    }
    //다음 Type t 실행 중 올바로 동작하지 않는 것을 고르시오
    class Ex1_2
    {
        static void Main(string[] args)
        {
            //문제1
            object myObject = "MyObject";

            Type t;
            t = myObject.GetType();     //OBJECT.GetType() : OBJECT의 타입을 반환함
            t = typeof("int");          //typeof : 타입 형식을 입력받음. ex) int, double, object, Type ...
            t = Type.GetType(int);      //Type.GetType(string typeName) : 문자열로 타입을 입력받음
            t = Type.GetType("System.Int32");

            //문제2
            //애트리뷰트와 주석의 차이
            //애트리뷰트 : C# 컴파일러가 읽어서 정보를 활용함 -> 변경사항에 대한 내용을 메소드 실행시 알릴 수 있음
            //주석 : 사람이 직접 찾아서 읽어야함 -> README 파일을 통해서 변경사항에 대해 파악
        }
    }

    
}