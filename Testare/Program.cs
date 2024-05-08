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
            //int x = 3, y = 2;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write(x++ + y);
            //}
            //// => 567


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
            // Console.WriteLine(int.MaxValue + 1 == int.MinValue ? "primul caz" : "celalalt caz");
            // eroare nu merge +1 , da eroare la rulare
            // este eroare la rulare, deoarece nu poti rula programul ca este eroare
            // eraorea la compilare este atunci cand programul ruleaza dar apare o eroare pe parcurs gen

            //6
            //Console.WriteLine(args.Length + " " + Environment.GetCommandLineArgs().Length);   afiseaza 0  1
            //mie imi arata 0  1


            //7
            //int x = 4, y = x++;
            //Console.WriteLine(x); //5
            //Console.WriteLine(y); //4
            //Console.WriteLine(x + "-" + y); //5-4
            //Console.WriteLine(y / x); // 5/4 = 0
            //=> 0 ???
            //x/y = 1 ???


            //8
            //string xs = "hello";
            //xs.Replace("l", "lll"); 
            //Console.WriteLine(xs);
            //hello
            //strings in c# are immutable, meaning that their values cannot be changed after they are created
            //You initialize a string variable xs with the value "hello".
            //You call the Replace method on the string xs, which creates and returns a new string with the replacements, but you don't assign this new string to any variable.
            //When you print the string xs to the console, it remains unchanged because the Replace method did not modify the original string.
            //In C#, strings are indeed reference types, but their immutability means that operations like Replace return new string objects rather than modifying the existing ones.
            //If you want to see the desired output, you need to assign the result of the Replace method to a variable, as shown in the corrected code in my previous response.
            // if i modify: xs = xs.Replace('l','lll') => Console.WriteLine(xs);  Output: hellllllo


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
            // return: Use of unassigned local variable 'adf'

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
            //14.1
            foreach (var item in Zile.GetNames(typeof(Zile)))
            {
                Console.Write(item + " ");
            }
            //14.2
            foreach (var item in Zile.GetValues(typeof(Zile)))
            {
                Console.Write(item + " ");
            }
            //B. SE ENUMERA DE 2 ORI VALORILE DIN ENUM
            //14.1 Luni Marti Miercuri Joi Vineri
            //14.2 Luni Marti Miercuri Joi Vineri

            //15. Care din urm sunt adevarate?
            /*
                1. Clasele sunt tipuri referinta  => Adevarat
                2. Struturile sunt tipuri referinta   => Structurile sunt de tip valoare
                3. O instanta a unei clase se numeste obiect => Adevarat
                4. O structura nu poate avea constructori > O strunctura poate avea constructori
            
            Adevarate:  1,3
                                      
                1. Adevarat. Clasele sunt de fapt tipuri referinta in c#. Atunci cand creati o varabila de tipul unei clase, variabila stocheaza adresa la care obiectul este stocat in memorie, 
                           nu obiectul insusi. Aceasta inseamna ca mai multe variabile pot face referire la acelasi obiect.
                2. Fals. Structurile sunt tipuri valoare in c#. Aceasta inseamna ca variabilele care stocheaza structuri contin direct valorile acestora, nu adresele la care sunt stocate in memorie. 
                   Tip valoare: variabilele care contin elemente ce stocheaza tip valoare contin direct valorile acestora
                   Tip referinta: variabilele care contin elemente ce stocheaza tip referinta, contin adresele la care sunt stocate in memorie

                   String este immutable, pentru a putea modifica o variabila de tip string trebuie sa cream un string nou si apoi se vor putea observa modificarile. vezi punctul 8
             */           

            //16
            /*
                1. O clasa poate suprascrie o metoda, din clasa de baza,doar daca metoda este declarata abstracta sau virtual in clasele de baza. A
                2. Structurile nu pot mosteni o alta clasa sau structura dar pot implementa interfete. A
                3. O clasa ne-abstracta trebuie sa suprascrie toate metodele abstracte ale clasei de baza. F
                4. O clasa abstracta NU poate fi instantiata. A
                5. O clasa sealed NU poate fi instantiata. F => poate fi instantiata insa nu poate fi mostenita
                6. O clasa abstracta poate fi mostenita. A => nu poate fi instantiata
                7. O clasa sealed poate fi mostenita. F
                8. O clasa poate implementa mai multe interfete. A
                9. O clasa poate mosteni mai multe clase. F   => Mostenirea multipla se face cu ajutorul interfetelor
            
                Adevarate: Toate inafara de 5 si 7 ??? 

                1. Adevărat. O clasă poate suprascrie o metodă din clasa de bază doar dacă metoda este declarată abstractă sau virtual în clasa de bază.
                2. Adevărat. Structurile nu pot moșteni alte clase sau structuri, dar pot implementa interfețe.
                3. Fals. O clasă neabstractă nu trebuie să suprascrie toate metodele abstracte ale clasei de bază. Aceasta trebuie să facă doar dacă este o clasă concretă (nu abstractă).
                4. Adevărat. O clasă abstractă nu poate fi instanțiată. Ea poate fi utilizată doar ca o clasă de bază pentru alte clase.
                5. Fals. O clasă sealed nu poate fi moștenită, dar poate fi instanțiată.
                6. Adevărat. O clasă abstractă poate fi moștenită. Este creată pentru a fi o clasă de bază pentru alte clase.
                7. Fals. O clasă sealed nu poate fi moștenită.
                8. Adevărat. O clasă poate implementa mai multe interfețe.
                9. Fals. O clasă poate moșteni doar o singură clasă. În C#, nu există moștenire multiplă a claselor.

             Când clasa este definită ca sigilată, atunci acea clasă nu poate fi moștenită și, de asemenea, că Clasa sigilată nu poate fi utilizată ca clasă de bază. Sealed Class este utilizat în principal în scopul restricționării aspectului moștenirii OOP.
             https://ro.education-wiki.com/5214984-sealed-class-in-c
             */
            
            Console.ReadKey();
        }
    }
}
