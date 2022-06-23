using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class Program
    {
        /*
         S - Single Responsability Principle;
         O - Open-Closed Principle;
         L - Liskov Substitution Principle; 
         I - Interface Segregation Principle; 
         D - Dependency Inversion Principle;

        Solid focus is to create loosely coupled architectures
        with a high level of maintainability.

        - cleaner and more organized code.
         */


        // 1. SRP - Using Single Responsability Principle we have two different classes, like below example
        public static class Logging
        {
            public static void Log(string msg)
            {
                string path = @"C:\\Users\\Admin\\Desktop\\Logger"+@"\log - " + System.DateTime.Today.ToString("MM-dd-yyyy") +".txt";
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(msg);
                    sw.WriteLine(" - " + System.DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("-------------------------------------");
                }
            }
        }

        class Solution
        {
            public int Sum(int numberOne, int numberTwo)
            {
                int rezult = numberOne + numberTwo;
                Logging.Log($"Sum Operation: {numberOne} + {numberTwo} = {rezult}.");
                return rezult;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int rez = s.Sum(4, 5);
            Console.Write("Sum = " + rez);
            Console.ReadKey();
        }
    }
}
