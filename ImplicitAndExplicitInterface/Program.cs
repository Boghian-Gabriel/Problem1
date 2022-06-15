using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. With implicit Interface
            //Test test = new Test();
            //test.message = "Implicit Interface!";

            //int var = test.Sum(2, 3);
            //Console.WriteLine(var);
            //test.TestMethod();


            // 2. With explicit interface
            Itest2 obj = new TestWithExplicitInterface();
            obj.TestMethod2();
            Console.ReadKey();
        }
    }
}
