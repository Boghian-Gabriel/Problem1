using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoaneAndVocale
{
    internal class Program
    {
        public static bool IsVowel(string str)
        {
            str = str.ToLower();
            char[] character = str.ToCharArray();
            for(int i = 0; i < str.Length; i++)
            {
                if(character[i] == 'a' || character[i] == 'e' || character[i] == 'i' || character[i] == 'o' || character[i] == 'u')
                    return true;
                else if(character[i] != 'a' || character[i] != 'e' || character[i] == 'i' || character[i] != 'o' || character[i] != 'u')
                {
                    return false;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Introdu cuvantul: ");
            string str = Console.ReadLine().ToLower();
            string  voc = "aeiou";
            List<char> lstVocale = new List<char>();
            lstVocale.AddRange(voc);
            //nr de vocale din string
            var nrVoc = str.Count(c => lstVocale.Contains(c));
            int nrTotalLitere = str.Length;
            int nrTotalDeConsoane = nrTotalLitere - nrVoc;
            
            bool result = IsVowel(str);
            if (result)
            {
                Console.WriteLine("DA - CONTINE VOCALE");
            }
            else
            {
                Console.WriteLine("NU - NU CONTINE VOCALE");
            }
            Console.ReadKey();
        }
    }
}
