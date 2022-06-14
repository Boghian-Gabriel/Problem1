using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMDC
{
    internal class Program
    {
        /*
         CMMDC: 12 si 14 este 2
         Alg. Euclid prin scaderi repetate
        Observații:
        1. Dacă unul dintre numere este 0, celălalt este cmmdc.
        2. Două numere sunt prime între ele dacă au cmmdc 1.
        3. Algoritmul prin împărțiri repetate este, de cele mai multe ori, mai rapid decât cel prin
           scăderi repetate.
         */
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            int n2 = int.Parse(Console.ReadLine());
            int number1 = n1, number2 = n2;
            //Alg.lui Euclid prin Scaderi repetate
            while (n1 != n2)
            {
                if (n1 > n2) n1 = n1 - n2;
                else n2 = n2 - n1;
            }
            Console.Write($"\nCMMDC between {number1} and {number2} is: " + n1);

            //Alg. lui Euclid prin Impartiri repetate
            //int r = n1 % n2;
            //while (r != 0)
            //{
            //    n1 = n2;
            //    n2 = r;
            //    r = n1 % n2;
            //}
            //Console.Write(n2);
        }
    }
}
