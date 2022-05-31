using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    internal class Dacia : Cars, IExtra
    {

        public string Color { get; set; }
        public int Price { get; set; }

        //methods from abstract class
        public override double dprice()
        {
            return 50;
        }

        public override int GetTotalSeat()
        {
            return 80;
        }

        //from Interface
        public string colors(string color)
        {
            return color;
        }

        public int getTotalSeat()
        {
            return 100;
        }

        public double price(int pr)
        {
            return pr;
        }
    }
}
