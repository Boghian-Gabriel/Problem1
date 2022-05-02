using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            // step 1 : Print number from 1 to n
            for(int i=0; i <= n; i++)
            {
                // step 2 : Divizible by 3 prin Fizz
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // step 3 : Divizible by 5 prin Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //Step 4 : Divizible by 3 and 5 print FizzBuzz
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    // Display the numbers...
                    Console.WriteLine(i);
                }
            }
            //The console can wait for a push of a button
            Console.ReadKey();
        }
    }
}
