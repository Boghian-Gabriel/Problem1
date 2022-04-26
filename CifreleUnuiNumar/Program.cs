using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifreleUnuiNumar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number:");
            int.TryParse(Console.ReadLine(), out number);
            int contor = 0;
            while(number != 0){
                int uc = number % 10;
                contor++;
                Console.WriteLine("Cifra " + contor+ " este " + uc + " ");
                number /= 10;
            }
            Console.ReadKey();
        }
    }
}
