using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMaxSumFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n=int.Parse(Console.ReadLine());

            int []arr=new int[n];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            int min = arr[0], max=arr[0];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>max) max=arr[i];
                else if(arr[i]<min) min=arr[i];

            }
            Console.WriteLine();
            Console.WriteLine(min + " - " + max);
            int s = 0;
            Console.WriteLine();
            for(int i=0; i<arr.Length; i++)
            {
                s += arr[i];
            }
            int smax, smin;
            smax = s - min;
            smin = s - max;
            Console.WriteLine();
            Console.WriteLine(smin + " - " + smax);
            Console.ReadKey();
        }
    }
}
