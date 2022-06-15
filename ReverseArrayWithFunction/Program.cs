using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayWithFunction
{
    internal class Program
    {
        public static int[] ReverseArray(int[] arr1, int n)
        {
            int[] arr2 = new int[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                //count - iteratia -1, deoarece indexul incepe de la zero.
                arr2[i] = arr1[arr1.Length - i - 1];
            }
            return arr2;
        }

        static void Main(string[] args)
        {
            Console.Write("\nEnter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2;
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            arr2 = ReverseArray(arr1, n);
            Console.WriteLine();
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
