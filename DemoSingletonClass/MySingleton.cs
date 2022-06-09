using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSingletonClass
{
    public class MySingleton
    {
         //static field for our singleton instance
         private static MySingleton instance = null;
        private MySingleton()
        {
        }

        public static MySingleton Instance
        {
            //aceasta parte este instantiata doar atunci cand este creat
            get { 
                if(instance == null)
                {
                    instance = new MySingleton(); 
                }
                return instance; 
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton class code has been colled");
            Console.ReadLine();
        }
    }
}
