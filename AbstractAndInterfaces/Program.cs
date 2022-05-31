using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opel opel = new Opel();
            //opel.dprice();
            //opel.getTotalSeat();


            //opel.Wheel();
            //opel.CheckAC();
            //opel.CallFacility();

            Console.WriteLine(opel.dprice());
            Console.WriteLine(opel.getTotalSeat());

            Console.WriteLine(opel.Wheel());
            Console.WriteLine(opel.CheckAC());
            Console.WriteLine(opel.CallFacility());

            Console.ReadKey();

        }
    }
}
