using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Program
    {
        /*
         <-Main aspects->
         1. This program verify is a string is palindrom or not.
         2. In the second step, this program checks if the word written reverse is equal to the original string.
         3. In the last step, same program return a message with this value: true or false.
         4. Tommorow, i will rewrite this program tomorrow, because I want to, and I'll put some of the code into a function and then call it from the main function.
         */
        static void Main(string[] args)
        {
            string s, revs = String.Empty;
            bool isTrue = false;

            Console.WriteLine("Enter a string");
            s = Console.ReadLine();

            //revs , in I stochez ultimul si merg pana la inceput
            //parcurg descrescator cuvantul
            for(int i = s.Length-1; i >=0; i--)
            {
                //rescriu cuvantul invers caracter cu caracter
                revs = revs + s[i];
            }
            // s == revs  - aici nu tinea cont de litere mici sau mari
            //compar sirul initial cu cel rescris de la final la inceput, eliminand criteriul cu majuscule
            if (s.Equals(revs, StringComparison.CurrentCultureIgnoreCase))
            {
                isTrue = true;
                Console.WriteLine(isTrue);
                Console.WriteLine($"Sirul '{s}' este palindrom");
            }
            else
            {
                Console.WriteLine(isTrue);
                Console.WriteLine($"Sirul '{s}' nu este palindrom");
            }

            //The program waits for you to press a key on the keyboard and then it closes
            Console.ReadKey();
        }
    }
}
