using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name1: ");
            string word1 = Console.ReadLine();
            Console.Write("\nEnter name2: ");
            string word2 = Console.ReadLine();

            if(word1.Length == word2.Length)
            {
                char[] arr1 = word1.ToLower().ToCharArray();
                char[] arr2 = word2.ToLower().ToCharArray();

                Array.Sort(arr1);
                Array.Sort(arr2);


                bool bVal = true;

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        bVal = false;
                    }
                    else
                    {
                        bVal = true;
                    }
                }
                Console.WriteLine(bVal);
            }
            else
            {
                Console.WriteLine("Both values must be of equal length !");
            }
       
            Console.ReadKey();
        }
    }
}
