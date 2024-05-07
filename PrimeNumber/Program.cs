internal class Program
{
    private static void Main(string[] args)
    {
        bool VerifySumOfDigits(int number, int iNrSumCifre)
        {
            int sum = 0, uc = 0;
            while (number > 0)
            {
                uc = number % 10;
                sum = sum + uc;
                number = number / 10;
            }

            if (sum == iNrSumCifre)
            {
                return true;
            }

            return false;
        }
        bool isPrimeNumber(int number)
        {
            int ctr = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) ctr++;
            }

            if (ctr == 2) return true;
            else return false;
        }

        Console.Write("Introdu suma pe care vrei sa o aiba cifrele numarului: ");
        int iSumaCifre = int.Parse(Console.ReadLine());
        Console.WriteLine();
        //afisam toate numere dintr-un anumit interval [a-b]
        Console.Write("Introdu valoarea de inceput a intervalului: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Introdu valoarea finala a intervalului: ");
        int b = int.Parse(Console.ReadLine());

        //afisam toate elementele din interval
        //Console.Write($"\nElementele din intervalul [{a}-{b}] sunt: ");
        //for (int i = a; i <= b; i++)
        //{
        //    Console.Write(i + " ");
        //}

        //afisam toate elementele prime din interval
        Console.Write($"\nElementele prime din intervalul [{a}-{b}] al caror suma cifrelor este {iSumaCifre} sunt:\n ");
        List<int> lstWithPrimeNumber = new List<int>();
        for (int i = a; i <= b; i++)
        {
            bool isPrime = isPrimeNumber(i);
            //if number is prime add to list

            if (isPrime || i == 1)
            {
                bool bVerifySumDigits = VerifySumOfDigits(i, iSumaCifre);
                if (bVerifySumDigits)
                {
                    lstWithPrimeNumber.Add(i);
                }
            }
        }

        foreach (var item in lstWithPrimeNumber)
        {
            Console.Write(item + " ");
        }

        Console.ReadKey();
    }
}