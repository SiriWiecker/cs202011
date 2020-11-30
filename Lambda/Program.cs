using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // en måde at skrive noget på
            int[] array = { 5, 1, 4, 1, 6, 7, 10 };
            int findes1 = System.Array.FindIndex(array, FindesTal);  // 4
            bool FindesTal(int a)
            {
                return a == 6;
            }

            // var noget nemmere at skrive (hvis man lige vender sig til syntaksen - smiler)
            int findes2 = System.Array.FindIndex(array, i => i == 6);   // 4
            // på venstre side står argumenterne på højreside står body'en



            int Test4(int a)
            {
                return a + 1;
            }

            // nedenstående 4 linjer er alle ens bare skrevet på forskellige måder
            Func<int, int> f12 = Test4;
            Func<int, int> f13 = (int x) => { return x + 1; }; // lambda
            Func<int, int> f14 = (x) => { return x + 1; }; // lambda
            Func<int, int> f15 = x => x + 1; // lambda (kun et argument, så behøver vi ikke paranteser)
            Console.WriteLine(f12(1));
            Console.WriteLine(f13(1));
            Console.WriteLine(f14(1));
            Console.WriteLine(f15(1));

            // husk at en lambda er en funktion så referencen skal ind et sted
            Func<int, int, int> d = (int a, int b) => { return a + b } ; 
            Func<int, int, int> c = (a, b) => a + b;

            // Linq


        }
    }
}
