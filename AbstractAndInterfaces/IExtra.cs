using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    internal interface IExtra
    {
        //al member and methos are abstract and public
        double price(int iNumber);
        int GetTotalSeat();
        string colors(string sColor);
    }
}
