using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regnemaskine__egne_delegates_
{
    class Program
    {

        public delegate int BeregnDelegate(int a, int b);

        static void Main(string[] args)
        {
            // Enten
            BeregnDelegate s = new BeregnDelegate(Plus);
            int res = Beregner(1, 1, s);
            Console.WriteLine(res);

            // eller
            BeregnDelegate s1 = Minus;
            int res2 = Beregner(1, 1, s1);
            Console.WriteLine(res2);

            // eller
            int res3 = Beregner(1, 1, Gange);
            Console.WriteLine(res3);

            // Prøv også at skabe en metode FindTilfældigFunktion, der returnerer en 
            // Beregn-delegate med en af de fire metoder(plus, minus, gange eller divider) 
            // afhængig af det konkrete millisekund(under 250 = plus, 250 - 500 = minus osv).
            // kald til funktionen kan se således ud:
            // Find tilfældig
            var f = FindTilfældigFunktion();
            int res4 = f(5, 5);
            // eller
            // int res4 = FindTilfældigFunktion()(5,5);
            Console.WriteLine(res4);

        }

        // Du skal skabe en tom konsol app med følgende metoder:
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }

        // Dan en delegate kaldet Beregn, som kan bruges til at kalde en af ovennævnte funktioner, 
        // og skab en metode Beregner der tager to heltal til beregning, samt en instans af en de-
        //legate, der henviser der den funktion der ønskes benyttes. Kald kan se således ud:

        public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }

        public static BeregnDelegate FindTilfældigFunktion()
        {
            if (System.DateTime.Now.Millisecond <= 250)
                return Plus;
            if (System.DateTime.Now.Millisecond <= 500)
                return Minus;
            if (System.DateTime.Now.Millisecond <= 750)
                return Gange;

            return Divider;

        }

    }

}