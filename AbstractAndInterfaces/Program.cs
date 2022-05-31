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
            Console.WriteLine(opel.GetTotalSeat());

            Console.WriteLine(opel.Wheel());
            Console.WriteLine(opel.CheckAC());
            Console.WriteLine(opel.CallFacility());

            Console.WriteLine("--------------------------");
            //new class
            Dacia dacia = new Dacia();
            //from abstract class
            Console.WriteLine(dacia.dprice());
            Console.WriteLine(dacia.GetTotalSeat());
            //from interface
            var col = dacia.Color = "Red";
            var price = dacia.Price = 10000;
            Console.WriteLine(dacia.colors(col));
            Console.WriteLine(dacia.getTotalSeat());
            Console.WriteLine(dacia.price(price));
            Console.ReadKey();

        }
    }
}
