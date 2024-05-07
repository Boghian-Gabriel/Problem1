namespace Fibonacci
{
    internal class Program
    {
        //verificam daca numarul este patrat perfect atunci true, else false
        static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        //una din metode ce verifica pe baza functiei de mai sus daca nr este Fibonacci
        static bool ItemIsFibonacci(int number)
        {
            return IsPerfectSquare(5 * number * number + 4) ||
                   IsPerfectSquare(5 * number * number - 4);
        }

        static void Main(string[] args)
        {
            Console.Write("Introdu numarul de elemente din vector: ");
            int nr = int.Parse(Console.ReadLine());
            int[] v = new int[nr];

            Console.Write("Introdu elementele din vector:\n ");
            for (int i = 0; i < nr; i++)
            {
                Console.Write($"v[{i}] = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nVectorul initial este: ");
            for (int i = 0; i < nr; i++)
            {
                Console.Write(v[i] + " ");
            }

            List<int> lstWithFibonnaciItem = new List<int>();
            int iContor = 0;
            //verific daca fiecare element din vector face parte din sirul fibonnaci
            for (int i = 0; i < nr; i++)
            {
                int item = v[i];
                if (ItemIsFibonacci(v[i]))
                {
                    iContor++;
                    lstWithFibonnaciItem.Add(item);
                }
            }

            Console.Write($"\nIn vectorul alcatuit anterior, sunt {iContor} numere Fibonacci, iar acestea sunt: ");
            foreach (var item in lstWithFibonnaciItem)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}