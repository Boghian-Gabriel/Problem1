using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClass
{
    internal sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());

        }
        
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


        //What is a nested class in C#?
        // Whenever we defined a class within another class in C# then the inner
        // class is called a nested class or child class.
        
        //When the parent class is sealed, we can not uses inheritance
        //public class DerivedSingleton : Singleton
        //{

        //}
    }
}
