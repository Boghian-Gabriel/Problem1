using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare
{
    internal class Program
    {
        //11
        private class Exemplu
        {
            public int x;

            public Exemplu()
            {
                x = 0;
            }
            public Exemplu(int x)
            {
                this.x = x;
            }
        }

        //13.
        class Persoana
        {
            public string Nume { get; set; }
            internal int Varsta { get; set; }
            //desctructor
            ~Persoana() { }
        }


        //14.
        enum Zile
        {
            Luni,
            Marti,
            Miercuri,
            Joi,
            Vineri
        }
        static void Main(string[] args)
        {
            //1
            //int x = 3, y = 2;
            //Console.Write(x++ + y++);
            //Console.Write(++x + y++);
            //Console.Write(x);
            //Console.Write(y);
            // => 5854

            //2
            /*
             int x=3, y=2;
            for(int i=0; i<3; i++){
                Console.Write(x+++y);
            }
            // => 567
             */

            //3
            //for(int j=0; j<"un sir".Length; j++)
            //{
            //    Console.Write(j);
            //}
            //012345


            //4
            //int i = 0;
            //for (; i < 5; i++)
            //{
            //    Console.Write(i);
            //} 
            // => 01234


            //5
            //Console.WriteLine(int.MaxValue + 1 == int.MinValue ? "primul caz" : "celalalt caz");
            // eroare nu merge +1 , da eroare la rulare
            //este eroare la rulare, deoarece nu poti rula programul ca este eroare
            // eraorea la compilare este atunci cand programul ruleaza dar apare o eroare pe parcurs gen

            //6
            //Console.WriteLine(args.Length + " " + Environment.GetCommandLineArgs().Length);   afiseaza 0  1
            //mie imi arata 0  1


            //7
            //int x= 4, y= x++;
            //Console.WriteLine(x + "-" + y);
            //Console.WriteLine(y / x);   
            //=> 0
            //x/y = 1


            //8
            //string xs = "hello";
            //xs.Replace("l", "lll");
            //Console.WriteLine(xs);
            //hello

            //9
            //string x = "abcde";
            //foreach (char c in x)
            //  c++;
            // Console.WriteLine(x);
            //eroare, nu poti face ++ cand e foreach

            //11
            //int x= 2;
            //Exemplu adf;
            //Console.WriteLine(adf.x);  
            // ->eroare la rulare cred deoarece nu este Exemplu adg = new Exemplu();

            var a = new[]
            {
                new[] { 1, 2 },
                new[] { 3, -1, 6 }
            };
            Console.WriteLine(a[0][1]);
            // Rez => 2


            //13.
            var persoana = new List<Persoana>
            {
                new Persoana{Nume="Andrei", Varsta=25},
                new Persoana{Nume="Ioan", Varsta=43},
                new Persoana{Nume="Alexandra", Varsta=31}
            };

            var result = persoana
                .Where(p => p.Varsta >= 30)
                .OrderBy(p => p.Nume);

            foreach (Persoana p in result)
            {
                Console.WriteLine(p.Nume + "-" + p.Varsta);
            }
            //Afiseaza Alexadra-31 , Iona-43


            //14.
            foreach (var item in Zile.GetNames(typeof(Zile)))
            {
                Console.Write(item + " ");
            }

            foreach (var item in Zile.GetValues(typeof(Zile)))
            {
                Console.Write(item + " ");
            }
            //B. SE ENUMERA DE 2 ORI VALORILE DIN ENUM
            //Luni Marti Miercuri Joi Vineri Luni Marti Miercuri Joi Vineri

            //15. Care din urm sunt adevarate?
            /*
             1. Clasele sunt tipuri referinta
             2. Struturile sunt tipuri referinta
             3. O instanta a unei clase se numeste obiect
             4. O structura nu poate avea constructori
            Adevarate:  1,3
             */

            //16
            /*
            1. O clasa poate suprascrie o metoda, din clasa de baza,doar daca metoda este declarata abstracta sau virtual in clasele de baza. A
            2. Structurile nu pot mosteni o alta clasa sau structura dar pot implementa interfete.
            3. O clasa ne-abstracta trebuie sa suprascrie toate metodele abstracte ale clasei de baza
            4. O clasa abstracta nu poate fi instantiata.
            5. O clasa sealed nu poate fi instantiata. F
            6. O clasa abstracta poate fi mostenita.
            7. O clasa sealed poate fi mostenita. F
            8. O clasa poate implementa mai multe interfete.
            9. O clasa poate mosteni mai multe clase.
            Adevarate: Toate inafara de 5 si 7 


            Când clasa este definită ca sigilată, atunci acea clasă nu poate fi moștenită și, de asemenea, că Clasa sigilată nu poate fi utilizată ca clasă de bază. Sealed Class este utilizat în principal în scopul restricționării aspectului moștenirii OOP.
             https://ro.education-wiki.com/5214984-sealed-class-in-c
             */


            /*
             
            */
            Console.ReadKey();
        }
    }
}
