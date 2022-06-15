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
            //Itest2 obj = new TestWithExplicitInterface();
            //obj.TestMethod2();
            //Console.ReadKey();

            //Difference between  out and ref
            // out  return multiple value
            // ref - schimbarea se resimte si la declarare
            int G;
            int G2 = 0;
            

            Sum(out G);
            Sum2(ref G2);
            Console.WriteLine(G2);
            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", G);

            Console.WriteLine("The sum of" +
                    " the value is: {0}", G2);
        }
        public static void Sum(out int G)
        {
            G = 10;
            G++;

        }

        public static void Sum2(ref int G)
        {
            // Check parameter value
            if (G == 0)
            {
                Console.WriteLine("It's true!");
            }

            G = 20;
        }
    }
}
