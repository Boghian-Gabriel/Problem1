using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    // An abstract class isa special class that contains both abstract and non-abstract members in it.

    public abstract class Cars
    {
        //Abstract class can contain abstract methods/ abstract member but also cand contain non-abstract
        public abstract double dprice();
        public abstract int GetTotalSeat();

        // Required:
        /*
         * We cannot create object of an abstract class;
         */

        public string Wheel()
        {
            return "4 wheeler";
        }

        public string CheckAC()
        {
            return "AC is available";
        }

        public string CallFacility()
        {
            return "Call Facility supported";
        }
    }

    // Interfaces.
    /*
     * Interface contain only abstract methods.
     * Cannot create object of an interface.
     * default scope for a member in Interface is Public. no need t use the Public access specifier
     */
    // OBS: In case of multiple inheritance, use Interface.
}
