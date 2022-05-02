using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetween__i_i__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("1. Enter a number: ");
            n = int.Parse(Console.ReadLine());

            int i = 1;
            n += ++i;
            Console.Write("The n value (++i) is equal to = " + n);
            Console.WriteLine("");
            //reset the value of n
            Console.Write("2. Enter a number: ");
            n = int.Parse(Console.ReadLine());
            i = 1;
            n += i++;
            Console.Write("The n value (i++) is equal to = " + n + "\n");
        }
    }
}
