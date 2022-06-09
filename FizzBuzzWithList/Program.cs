using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWithList
{
    internal class Program
    {
     //Create a function that return a list of first 100 numbers.
        public static List<int> GetInteger()
        {
            const int numberOfIntegers = 100;
            List<int> listOfIntegeres = new List<int>();

            for(int i = 1; i <=numberOfIntegers; i++)
            {
                listOfIntegeres.Add(i);
            }
            return listOfIntegeres;
        }

        //Create a function that reutrn a list number.
        //The number of numbers is enterig by the keyboard.
        public static List<int>GetInteger2(int n)
        {
            List<int> listOfIntegeres = new List<int>();
            for(int i = 1; i <=n; i++)
            {
                listOfIntegeres.Add(i);
            }
            return listOfIntegeres;
        }

        private static void FizzBuzz(List<int> list)
        {
            string rez;
            foreach (var item in list)
            {
                List<int> lFizzBuzz = new List<int>();
                if (item % 3 == 0 && item % 5 == 0)
                {
                    rez = "FizzBuzz";
                    lFizzBuzz.Add(item);
                }
                else if (item % 3 == 0) rez = "Fizz";
                else if (item % 5 == 0) rez = "Buzz";
                else rez = item.ToString();

                Console.WriteLine(rez);

                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.Write("This list will display only FizzBuzz numbers: ");
                    foreach (var f in lFizzBuzz)
                    {
                        Console.Write(" " + f);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            //Declare another list can hold all 100 numbers.
            List<int> list = GetInteger();
            //Calling the function FizzBuzz.
            FizzBuzz(list);
            Console.WriteLine();
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            //declare another list with n number of numbers
            List<int> list2 = GetInteger2(num);
            FizzBuzz(list2);
            Console.ReadLine();
        }
    }
}