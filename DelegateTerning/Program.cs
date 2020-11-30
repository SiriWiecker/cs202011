using System;
using System.Text.RegularExpressions;

namespace DelegateTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vi laver en ny terning hvor vi udskriver terningens værdi
            Terning t = new Terning();
            
            //de to nedenstående er helt ens - bare to forskellige måder at skrive det samme på
            // t.TilfældigTalFunktion = new TilfældigtTalDelegateVoidInt(FT); // angiv en ny delegate og inden i angive en reference til en metode
            t.TilfældigTalFunktion = FT;
            
            t.Ryst();
            Console.WriteLine(t.Værdi);
        }

        // Denne FT laver brugeren/udvikler B selv, så man har afkoblet funktionaliteten. Svend bestemmer hvordan der skal rystes. Ikke mig der laver terningen.
        // Funktionaliteten er afkoblet.
        // lige nu lader vi det være op til udvikler B at komme med en metode at ryste på. Hvis udvikler B ikke angiver noget, så fejler den.
        // Derfor laver vi en kontrol nede i "FindTal()"
        public static int FT()
        {
            return new Random().Next(1, 7);
        }

        class Terning
        {
            //public void Ryst()
            //{
            //    this.Værdi = new Random().Next(1, 7);
            //}

            //public int Værdi { get; set; }





            // Vi vil gerne afkoble ryst funktionen
            // dvs. vi vil godt have at brugeren selv kan bestemme ryst
            public void Ryst()
            {
                this.Værdi = FindTal();
            }

            public int Værdi { get; set; }

            public TilfældigtTalDelegateVoidInt TilfældigTalFunktion { get; set; }

            public int FindTal()
            {
                // return new Random().Next(1, 7);
                // vi kan i stedet bruge delegate som vi lige har oprettet:

                // de to nedenstående er det samme bare skrevet på to forskellige måder
                if (TilfældigTalFunktion != null)
                {
                    // return TilfældigTalFunktion.Invoke();
                    return TilfældigTalFunktion();
                }
                else
                {
                    return 1;
                }
            }
        }

        // For at få koden ti lat virke, er det essentielt med nedenstående delegate!
        // Nu vil vi gerne lave en delegate og det skal være på niveau med klasser
        public delegate int TilfældigtTalDelegateVoidInt(); // samling af lister men har intet at gøre med terning endnu
        // for at få den til at have noget med terning at gøre lgiesom i "TilfældigtTalDelegateVoidInt"
        //Et alternativ til alle disse definitioner af delegates er en "ACtion" eller en "Func"

        // En metode der tager en streng som argument
        // Action bruges når det den returnerer en void, så det er en void med enten ingen eller fler argumenter.
        // En Action er en delegate med en Action kan ikke returnere noget. 
        // En Action er altid en void.

        //En Func er en delegate der returnerer noget og har argumenter (eller ingen argumenter)
        // en Func skal altid returnere en returværdi/output
        
        // Func<string, string, int> f4 // = LægSammen(); // det sidste argument i Func<..> er altid returværdien

        private static int LægSammen(int a, int b)
        {
            return a + b;
        }


        // En predicate tager kun ét argument altid. Og den returnerer altid en boole.
        // Func<int, bool> f6 = Match;
        // Predicate<int> f7 = Match;

    }
}
