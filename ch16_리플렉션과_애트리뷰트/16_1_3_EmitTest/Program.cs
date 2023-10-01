using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    public class MainApp
    {
        public static void Main()
        {
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calcaulator");
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",    //타입명
                MethodAttributes.Public,  //특성 한정자
                typeof(int),    //반환형식 int
                new Type[0]);   //매개변수 없음

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for (int i=2;i<=100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }

            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }
}