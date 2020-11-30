using System;
using System.Collections.Generic;

namespace Ø120_5_Brug_af_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };

            // Dit job er nu at kalde a.FindIndex – både ved at benytte en metode Find du selv har lavet, og ved at 
            // benytte en lambda(prøv en lambda med return og uden). Metoden skal returnere true hvis værdien = 51.
            Console.WriteLine();
            Console.WriteLine(a.FindIndex(FindVærdi));
            Console.WriteLine(a.FindIndex((i) => { return i == 51; }));
            Console.WriteLine(a.FindIndex(i => i == 51));
            
            // Herefter skal du kalde a.ForEach – både ved at benytte en metode ListVærdi du selv har lavet, og ved 
            // at benytte en lambda. Metoden skal blot udskrive alle værdier med en Console.WriteLine.
            Console.WriteLine();
            a.ForEach(ListVærdi);
            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });
        }

        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        //public delegate bool Predicate<int>(int findVærdi);

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }

    }
}
