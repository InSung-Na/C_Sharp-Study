using System;
using System.Transactions;

namespace RecordComp
{
    class CTranscation
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }
    
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTranscation trA = new CTranscation { From="Alice", To="Bob", Amount=100 };
            CTranscation trB = new CTranscation { From="Alice", To="Bob", Amount=100 };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}\n");  //Equals는 참조 데이터가 동일한지 확인하는 메서드

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");

        }
    }
}