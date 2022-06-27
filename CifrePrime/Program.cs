using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifrePrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //List cu cifrele unui numar
            List<int> nrCifreList = new List<int>();
            //Cifrele unui numar:
            int uc = 0;
            int nrCifre = 0, cNrPrime = 0 ;
            bool isNrPrim = false;
            int copie = number;
            while(copie > 0)
            {
                uc = copie % 10;
                //Console.Write("{0} ", uc);
                if (uc % 2 == 0)
                {
                    isNrPrim = true;
                }
                nrCifreList.Add(uc);
                nrCifre++;
                copie = copie / 10; //eliminam ultima cifra, trunchiem numarul.
            }
            Console.WriteLine("\nNumarul {0} are {1} cifre ", number, nrCifre);

            Console.WriteLine("\nCifrele numarului sunt: ");
            foreach(var item in nrCifreList)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
