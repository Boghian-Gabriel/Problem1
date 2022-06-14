using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveEvenElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for elements in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Element {i} = ");
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            //List<int> list = new List<int>();

            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr1[i] % 2 == 0)
            //    {
            //        list.Add(arr1[i]);
            //    }
            //}
            //Console.WriteLine("\nList with even elements from array: ");
            //foreach(var evenElem in list)
            //{
            //    Console.Write(evenElem + " ");
            //}
            //number of even element in the first array
            int cntEven = 0, cntOdd = 0;
            for(int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] % 2 == 0)
                {
                    cntEven++;
                }
                else
                {
                    cntOdd++;
                }
            }
            Console.Write("Number of even element is: " + cntEven + "\n");

            Console.WriteLine();
            //initial toate elementele din vector sunt 0
            int  []evenArray = new int[n];
            int[] oddArray = new int[n];
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] % 2 == 0)
                {
                    evenArray[i] = arr1[i];
                }
                else
                {
                    oddArray[i] = arr1[i];
                }
            }
            //e ok si asa , insa parcurgerea tot se face
            //trebuie sa modific
            for(int i=0; i < evenArray.Length; i++)
            {
                if (evenArray[i] != 0)
                {
                    Console.Write(evenArray[i] + " ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < oddArray.Length; i++)
            {
                if (oddArray[i] != 0)
                {
                    Console.Write(oddArray[i] + " ");
                }
            }


            Console.ReadKey();
        }
    }
}
