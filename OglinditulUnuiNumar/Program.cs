using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OglinditulUnuiNumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; //This is the number entered by the keyboard
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out number);

            int ogl = 0; //The variable in which we will calculate the result
            while(number != 0)
            {
                ogl = 10 * ogl + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Oglinditul este: " + ogl);
            Console.ReadKey();
        }
    }
}
