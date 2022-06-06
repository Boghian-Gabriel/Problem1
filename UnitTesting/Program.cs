using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        /*
         Popular Unit Testing frameworks
            1. MSTEST
            2. Nunit
            3. MbUNit
            4. net
        MSTEST is by default integrated with VS
         */
        public static int Divide(int numerator, int denominator)
        {
            int rezult = numerator / denominator;
            return rezult;
        }

        static void Main(string[] args)
        {
        }
    }
}
