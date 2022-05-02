using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This program that return the prime number which you entere form keyboard!
            Console.WriteLine("Enter a number: ");
            //Initialize n variable
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            //fact variable start at 1, because all number multiple by 1 rezult there number.
            int fact = 1;
            int contor = 0;
            for(int i = 1; i <=n; i++)
            {
                contor++;
                Console.WriteLine("Step " + contor + " => " + i);
                fact = fact * i;
            }
            Console.WriteLine("The number rezult" + n + "is: " + fact);

            //reinitialize
            contor = 0;
            fact = 1;
            Console.WriteLine("Enter another number: ");
            int ii = 1;
            while (ii <= m) {
                contor++;
                Console.WriteLine("Step " + contor + " => " + ii);
                fact = fact * ii;

                ii = ii + 1;
            }
            Console.WriteLine("The number rezult" + m + "is: " + fact);
            Console.ReadKey();
        }
    }
}
