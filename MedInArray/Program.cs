using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from array: ");

            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            Console.WriteLine("Enter element from array: ");
            for(int i = 0; i < number; i++)
            {
                try
                {
                    Console.Write("Elem [" + i + "] = ");
                    array[i] = int.Parse(Console.ReadLine());

                }catch(Exception ex)
                {
                    Console.WriteLine("Exceptie --> " + ex.Message);
                }
            }

            Console.Write("Display elements from array: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\nMed in array is : ");
            float med = 0;
            if(number %2 != 0)
            {
                med = array[array.Length / 2];
            }
            else
            {
                med = (float)((array[(array.Length / 2) - 1] + array[array.Length / 2] ) / 2.0f);
            }
            Console.WriteLine(med);
            Console.ReadKey();
        }
    }
}
