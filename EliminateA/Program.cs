using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliminateA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string strCopy = str.Replace('a', '@');

            Console.Write(strCopy);


            string[] words = strCopy.Split(' ');
            Console.WriteLine('\n');
            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            Console.ReadKey();
        }
    }
}
