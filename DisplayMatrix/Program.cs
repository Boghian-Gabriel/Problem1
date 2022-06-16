using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayMatrix
{
    internal class Program
    {

        //function enter matrix
        static void Enter2DArray(int[,] mat, int l, int c)
        {
            // Display the array elements.
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Mat[" + i + "][" + j + "] = ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //function display matrix
        static void Print2DArray(int[,] mat,int l,int c)
        {
            // Display the array elements.
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of line: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Enter number of collumn: ");
            int col = int.Parse(Console.ReadLine());

            int[,] mat = new int [line,col];

            //Console.WriteLine("Enter value: \n");
            //for(int i = 0; i < line; i++)
            //{
            //    for(int j = 0; j < col; j++)
            //    {
            //        Console.Write("Mat[" + i + "][" + j + "] = ");
            //        mat[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            // Console.WriteLine("\nMatrix is: \n");

            //for (int i = 0; i < line; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write(mat[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Enter2DArray(mat,line,col);
            Console.WriteLine("\nMatrix is: \n");
            Print2DArray(mat,line,col);

            Console.WriteLine("\nPress any keyword!");
            Console.ReadKey();
        }
    }
}
