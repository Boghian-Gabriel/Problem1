using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    internal class Program
    {
        #region "About SOLID"

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
        #endregion

        #region "SRP - Single Responsability Principle"

        // 1. SRP - Using Single Responsability Principle we have two different classes, like below example
        // SRP- A class should take one responsability and there
        // should be one reason to change that class.
        public static class Logging
        {
            static void WriteLogEntry(StreamWriter sw, string msg)
            {
                sw.WriteLine(msg + " - " + DateTime.Now.ToString("HH:mm:ss"));
                sw.WriteLine("-------------------------------------");
            }

            public static void Log(string msg)
            {
                //string sPath = Path.GetFullPath("Logger");
                //if(!Directory.Exists(sPath)) { Directory.CreateDirectory(sPath); }
                //string path = $@"{sPath}" + @"\log - " + DateTime.Today.ToString("MM-dd-yyyy") +".txt";
                //using(StreamWriter sw = File.OpenWrite(path))
                //{
                //    sw.Write(msg);
                //    sw.WriteLine(" - " + System.DateTime.Now.ToString("HH:mm:ss"));
                //    sw.WriteLine("-------------------------------------");
                //}

                string sPath = Path.GetFullPath("Logger");

                if (!Directory.Exists(sPath))
                {
                    Directory.CreateDirectory(sPath);
                }

                string path = Path.Combine(sPath, $"log - {DateTime.Today.ToString("MM-dd-yyyy")}.txt");

                if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        WriteLogEntry(sw, msg);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        WriteLogEntry(sw, msg);
                    }
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
        #endregion

        #region "OCP - Open / Closed Priciple "
        /*
         Using Open Closed Principle = have a base class, and each operation would be a new class
        
         A class should be open for extention but closed for any modification
         */
        public abstract class BaseCalculation
        {
            public abstract double Calculate(double n1, double n2);
        }

        //Addition
        public class AdditionCalculation : BaseCalculation
        {
            public override double Calculate(double n1, double n2)
            {
                return n1 + n2;
            }
        }
        //Multiplication
        public class MultiplicationCalculation : BaseCalculation
        {
            public override double Calculate(double n1, double n2)
            {
                return n1 * n2;
            }
        }
        //Substraction
        public class SubstractionCalculation : BaseCalculation
        {
            public override double Calculate(double n1, double n2)
            {
                return n1 - n2;
            }
        }
        //Division
        public class DivisionCalculation : BaseCalculation
        {
            public override double Calculate(double n1, double n2)
            {

                return n1 / n2;
            }
        }
        #endregion

        #region "LSP - Liskov Substitution Principle"

        #endregion

        #region "ISP - Interface Segregation Principle"
        public class AdditionCalculationISP
        {
            public int NumberA { get; set; }
            public int NumberB { get; set; }

            public AdditionCalculationISP(int numberA, int numberB)
            {
                this.NumberA = numberA;
                this.NumberB = numberB;
            }

            public virtual int Calculate(){
                return this.NumberA + NumberB;
            }
        }
        #endregion

        #region "DIP - Dependency Inversion Principle"
        //Constructor Injection

        //Property Injection

        // Method Injection
        #endregion

        static void Main(string[] args)
        {
         
            //SRP
            Solution s = new Solution();
            int rez = s.Sum(4, 5);
            Console.WriteLine("Sum = " + rez);

        
            //OCP
            AdditionCalculation additionCalculation = new AdditionCalculation();
            double nr1 = 6, nr2 = 8;
            double val = additionCalculation.Calculate(nr1, nr2);
            Console.WriteLine($"Addition is : {nr1} + {nr2} = {val}");


            BaseCalculation baseCalculation = new MultiplicationCalculation();
            double val2 = baseCalculation.Calculate(2, 3);
            Console.WriteLine("Multiplication is : " + val2);

            BaseCalculation bs2;

            bs2 = new SubstractionCalculation();
            Console.WriteLine("Substraction is : " + bs2.Calculate(5, 10));

            bs2 = new DivisionCalculation();
            try
            {
                Console.WriteLine("Division is : " + bs2.Calculate(4, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(" Cannot divide by zero! " + ex.Message);
            }
            finally
            {
                Console.Write("Executed try catch block");
            }

            //LSP

            //ISP

            //DIP:
            //a. Constructor Injection
            //b. Property Injection
            //c. Method Injection
 
            Console.ReadKey();
        }
    }
}
