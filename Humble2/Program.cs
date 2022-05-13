using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalindrom
{
    internal class Program
    {

        static bool isPalindrom(string inputString)
        {
            string reverse = string.Empty;

            for (int i = inputString.Length - 1; i>=0; i--) 
            {
                reverse += inputString[i];    
            }
            if(inputString.Equals(reverse, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("\nEnter a string: ");
            string s = Console.ReadLine();
            //stochez intr o variabila de tip booleana si apoi afisez
            bool isPalindromaa = isPalindrom(s);
            Console.WriteLine(isPalindromaa);
            Console.ReadKey();
        }
    }
}
