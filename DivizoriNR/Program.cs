using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivizoriNR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Divizorii lui {number} sunt: ");
            int cNrDiv = 0;

            for (int div =1; div<=number; div++)
            {
                if (number % div == 0)
                {
                    cNrDiv++;
                    Console.Write(div + " ");
                }
            }
            Console.WriteLine($"\nNr. de divizori ai lui {number} este {cNrDiv}");

            if (cNrDiv < 2)
            {
                Console.WriteLine("DA - ESTE PRIM");
            }
            else {
                Console.WriteLine("NU - NU ESTE PRIM");
            }
            Console.ReadKey();
        }
    }
}
