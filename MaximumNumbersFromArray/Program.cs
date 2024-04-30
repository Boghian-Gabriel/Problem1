using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumbersFromArray
{
    internal class Program
    {
        public static int FirstMaxim(int[] arr, int n)
        {
            int maxim = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > maxim)
                {
                    maxim = arr[i];
                }
            }
            return maxim;
        }
        public static int[] FindFirstTwoMaxim(int[] arr, int n)
        {
            int maxim1 = arr[0];
            int maxim2 = arr[1]; 
            int[] arr2 = new int[2]; 
            maxim1 = FirstMaxim(arr, n);
            for(int i = 0; i < n; i++)
            {
                if (arr[i] != maxim1 && arr[i] > maxim2)
                {
                    maxim2 = arr[i];
                }
            }
            arr2[0] = maxim1;
            arr2[1] = maxim2;
            return arr2;
        }

        public static int[] FindFirstTwoMaxim(int[] arr)
        {
            var sortedArray = arr.OrderByDescending(x => x).ToArray();
            return sortedArray.Take(2).ToArray();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine(n);
            Console.WriteLine("Enter the number of the array: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"array[{i}]= ");
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write($"\nYour array is: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\nThe first maxim of the array is: ");
            int result = FirstMaxim(array, n);
            Console.Write(result);

            Console.Write($"\nThe first and second maximum numbers in an array are {nameof(FindFirstTwoMaxim)} : ");
            var result2 = FindFirstTwoMaxim(array, n);
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }

            Console.Write($"\nThe first and second maximum numbers in an array are {nameof(FindFirstTwoMaxim)}: ");
            var resultLinq = FindFirstTwoMaxim(array);
            foreach (var item in resultLinq)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
