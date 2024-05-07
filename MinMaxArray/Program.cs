using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static List<int> GetMinMax(int[] arr1, int n)
        {
            List<int> result = new List<int>();
            int min = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] > max) max = arr1[i];
                else min = arr1[i];
            }

            result.Add(min);
            result.Add(max);

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements for the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            //min and max number from array
            int min = 0;
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr1[i] > max) max = arr1[i];
                else min = arr1[i];
            }
            Console.Write($"\n Max number is {max} and Min number is {min}");

            Console.Write($"\n Max number and Min number with function");

            var listMinMax = GetMinMax(arr1,n);
            Console.Write($"\n Max number is {listMinMax[1]} and Min number is {listMinMax[0]}");

            Console.ReadKey();
        }
    }
}
