using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number (minNumber): ");
            int intMin = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number (maxNumber): ");

            int intMax = int.Parse(Console.ReadLine());

            Random random = new Random();
            int number = random.Next(intMin, intMax);
            bool isEvenNumber = false;
            Console.WriteLine(number);

            if(number % 2 == 0)
            {
                isEvenNumber = true;
            }
            else
            {
                isEvenNumber = false;
            }

            if (isEvenNumber)
            {
                Console.WriteLine($"The number {number} is even!");
            }
            else
            {
                Console.WriteLine($"The number {number} is'n even!");
            }

            Console.ReadLine();
        }
    }
}
