using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0; 
            Console.Write("Enter a number: ");
            n=int.Parse(Console.ReadLine()); 
            
            while (n > 0)
            {             
                //Extract last digit from number
                int uc = n % 10;
                //add to sum
                sum = sum + uc;
                //eliminate the last digit
                n = n / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
