using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingletonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton Code Example
            MySingleton mySingleton = MySingleton.Instance;
            mySingleton.DoSomething();
        }
    }

}
