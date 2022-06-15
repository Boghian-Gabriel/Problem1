using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicitInterface
{
    internal class Test : ITest
    {
        public string message { get; set; }

        public int Sum(int a, int b)
        {
            return a+b;
        }

        public void TestMethod()
        {
            Console.WriteLine(message);
        }
    }
}
