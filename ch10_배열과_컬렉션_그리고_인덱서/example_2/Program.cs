using System;
using System.Collections;

namespace example_5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }
}