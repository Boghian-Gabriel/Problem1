using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        // Returns index of x if it is present in
        // arr[l..r], else return -1
        static int binarySearch(int[] arr, int left, int right, int x)
        {
            while (left < right)
            {
                int mid = (left + right) / 2;

                if (x == arr[mid]) return mid;
                else if (x < arr[mid]) right = mid - 1;
                else left = mid + 1;
            }
            return -1;
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
            Console.Write("Enter the number you want to search: ");
            int x = int.Parse(Console.ReadLine());


            //-----------------
            int result = binarySearch(arr1, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("The inserted element is not found in the array");
            else
                Console.WriteLine($"Element found at index {result}");
            Console.ReadKey();
        }
    }
}
