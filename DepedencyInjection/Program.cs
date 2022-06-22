 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messages messages = new Messages();
            messages.Log("Example about DI");
        }
        //using interface
        public interface ILogger
        {
            void Log(string message);
        }

        public class Messages : ILogger
        {
            public void Log(string message)
            {
                Console.WriteLine($"This message is : {message}");
            }
        }

       
    }
}
