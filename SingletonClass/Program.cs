using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton Design Pattern in C#.

            //Now. Let us modify the main method of the program
            //class to access the nested class as shown below.

            //The private constructor is called before that we creat object and instantiated him
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");

            /*
             * Instantiating singleton from a derived class.
             * This violates singleton pattern principles.
             */
            //Singleton.DerivedSingleton derivedSingleton = new Singleton.DerivedSingleton();
            //derivedSingleton.PrintDetails("From Derived");
        }
    }
}
