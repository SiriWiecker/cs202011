using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kan du godt se, at opgaven er præcis den samme som delegates-simpel-beregner? 
// Den opgave benytter din egen definition af en delegate - denne benytter blot den indbyggede Func<int, int, int>.

namespace Regnemaskine__beregner_med_func_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skab en metode Beregner der tager to heltal til beregning samt en Func, der henviser til den funktion der ønskes benyttes. Kald kan se således ud:
            int res = 0;
            res = Beregner(1, 1, Plus);
            Console.WriteLine(res);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(res);

            // Prøv også at skabe en metode FindTilfældigFunktion, der returnerer en Func (delegate) med en af de fire metoder (plus, minus, gange eller divider) 
            // afhængig af det konkrete millisekund (under 250=plus, 250-500=minus osv). kald til funktionen kan se således ud:
            var f = FindTilfældigFunktion();
            res = f(5, 5);
            Console.WriteLine(res);

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
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

        public static Func<int, int, int> FindTilfældigFunktion()
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