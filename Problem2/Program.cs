using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
		/*Un program sa obtina in cel mai scurt timp oricare din primele 5842 de numere umile. 
		 * Un numar umil este numarul care are divizori doar puteri ale numerelor 2,3,5,7.
Primele 20 de nr umile sunt 1,2,3,4,5,6,7,8,9,10,12,14,15,16,18,20,21,24,25,27  al 5842 este 2.000.000.000
Input : indexul nr umil
Output: nr umil avand indexul specificat
Ex.
1->1
11->12
17->21*/
		static int Humble(int n)
		{
			int[] humble = new int[5842];

			int a, b, c, d, i;
			a = b = c = d = 0;

			humble[0] = 1;

			for (i = 1; i < 5842; i++)
			{
				humble[i] = Math.Min(Math.Min(humble[a] * 2, humble[b] * 3), Math.Min(humble[c] * 5, humble[d] * 7));

				if (humble[i] == humble[a] * 2)
					a++;

				if (humble[i] == humble[b] * 3)
					b++;

				if (humble[i] == humble[c] * 5)
					c++;

				if (humble[i] == humble[d] * 7)
					d++;
			}

			return humble[n];
		}

		public static void Main()
		{
			int index;
			Console.WriteLine("Enter the index of the humble number:");
			int.TryParse(Console.ReadLine(), out index);

			Console.WriteLine("The Humble Number " + index + " is : {0}", Humble(index));
		}
	}
}
