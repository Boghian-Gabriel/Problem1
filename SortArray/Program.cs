using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----------------------------------------\n");
            Console.Write("Read number of elements: ");
            int numberOfElements = 0;
            numberOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfElements];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("----------------------------------------\n");

            Console.Write($"Input {numberOfElements} elements in the array :\n");
            for (i = 0; i < numberOfElements; i++)
            {
                Console.Write("element - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < numberOfElements; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");

            //Sort array
            Array.Sort(array);
            Console.Write("\nElements in array ascending sort are: ");
            foreach (int val in array)
            {
                Console.Write("{0} ", val);

            }
            Console.ReadKey();
        }
    }
}
