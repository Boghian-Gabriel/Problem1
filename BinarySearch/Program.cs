using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        //Cautarea daca elemetul X se afla intr-un array.
        // Returns index of x if it is present in
        // arr[l..r], else return -1
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == x)
                {
                    return mid;
                }

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > x)
                {
                    return binarySearch(arr, l, mid - 1, x);
                }
                else
                {
                    // Else the element can only be present
                    // in right subarray
                    return binarySearch(arr, mid + 1, r, x);
                }

            }
            return -1;
        }


        static void Main(string[] args)
        {
            Console.Write("Enter number for elements in array: ");
            int n = int.Parse(Console.ReadLine());
            int []arr1 = new int[n];
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Element {i} = " );
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.Write("Enter number for searching: ");
            int x = int.Parse(Console.ReadLine());


            //-----------------
            int result = binarySearch(arr1, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);

        }
    }
}
