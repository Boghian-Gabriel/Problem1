using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicitInterface
{
    interface Itest2
    {
        void TestMethod2();
    }
    internal class TestWithExplicitInterface : Itest2
    {
        void Itest2.TestMethod2()
        {
            Console.WriteLine("Explicit Interface Implementation");
        }
    }
}
