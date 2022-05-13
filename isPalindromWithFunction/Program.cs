using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalindromWithFunction
{
    internal class Program
    {

        static void SortingString(string inputString)
        {
            //Console.WriteLine("Enter the elements of the array separated by ','\n");

            //inputString = Console.ReadLine();

            string[] myArray = inputString.Split(',');

            Array arr = myArray;

            Array.Sort(arr);
            Console.WriteLine("Alphabetical sorted array: \n");
            int contor = 0;
            foreach (var s in arr)
            {
                contor++;
                Console.WriteLine(contor + " - " + "{0}" + ",", s);
            }
            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("\nArray sorted by length");
            //Array sorted by length with LINQ (Language Integrated Query)
            var sortArraybyLenght = from x in myArray
                                    orderby x.Length
                                    select x;
            contor = 0;
            foreach (var s in sortArraybyLenght)
            {
                contor++;
                Console.WriteLine(contor + " - " + "{0}" + ",", s);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array separated by ','\n");

            string elem = Console.ReadLine();
            //string[] myArray = elem.Split(',');
            SortingString(elem);
            Console.ReadKey();
        }
    }
}
