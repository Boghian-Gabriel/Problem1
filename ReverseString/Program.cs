using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            Console.WriteLine(str);
            string reverse = string.Empty;
            Console.Write("Reverse string is: ");
            
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);

            Console.ReadKey();

        }
    }
}
