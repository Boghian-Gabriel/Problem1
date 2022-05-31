using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    public class Opel : Cars
    {
        private const int tSEAT= 50;
        private int Price { get; set; }
        // All abstract methods from based must be declared in child class
        public override int GetTotalSeat()
        {
            return tSEAT;
        }

        public override double dprice()
        {
            return Price;
        }
    }
}
