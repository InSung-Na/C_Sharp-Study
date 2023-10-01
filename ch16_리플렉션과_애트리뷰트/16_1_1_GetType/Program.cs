using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace GetType
{
    interface FactoryItem { };  //상위클래스

    class Car : FactoryItem     //상위클래스를 상속(인터페이스)받은 하위클래스
    {
        //필드
        private string Name;    //매개변수1
        private int Price;      //매개변수2
        public int CarLife { get; set; }    //프로퍼티

        //생성자
        public Car() { }        //형식1
        public Car(string name, int price) //형식2
        {
            Name = name;
            Price = price;
        }
        
        //메서드
        public void PrintInfo(int peopleCnt)
        {
            Console.WriteLine($"Name:{Name}, Price:{Price}, peopleCnt:{peopleCnt}");
        }
    }

    class MainApp
    {
        //상속클래스 출력
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("------ Interfaces ------");

            Type[] interfaces = type.GetInterfaces();
            foreach (Type i in interfaces)
                Console.WriteLine($"Name:{i.Name}");

            Console.WriteLine();
        }

        //필드멤버 출력
        static void PrintFields(Type type)
        {
            Console.WriteLine("------ Fields ------");
            FieldInfo[] fields = type.GetFields(
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine("Access:{0}, Type:{1}, Name:{2}",
                    accessLevel, field.FieldType.Name, field.Name);
            }
            Console.WriteLine();
        }

        //메서드 출력
        static void PrintMethods(Type type)
        {
            Console.WriteLine("------ Methods ------");

            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.Write("Type:{0}, Name:{1}, Parameter:",
                    method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();
                for (int i=0; i<args.Length; i++)
                {
                    Console.Write(args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //프로퍼티 출력
        static void PrintProperties(Type type)
        {
            Console.WriteLine("------ Properties ------");

            PropertyInfo[] properties = type.GetProperties();
            foreach( PropertyInfo property in properties)
            {
                Console.WriteLine("Type:{0}, Name:{1}",
                    property.PropertyType.Name, property.Name);
            }
            Console.WriteLine();
        }

        //생성자 출력
        static void PrintConstructors(Type type)
        {
            Console.WriteLine("------ Constructors ------");

            ConstructorInfo[] constructors = type.GetConstructors();
            foreach( ConstructorInfo constructor in constructors)
            {
                Console.Write(constructor.Name + "(");

                ParameterInfo[] parameters = constructor.GetParameters();

                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name);

                    if (i < parameters.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine(")");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            Car car = new Car("테슬라 모델 3", 5800_0000);
            type = car.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
            PrintConstructors(type);    // .ctor은 Constructor의 약자
        }
    }
}