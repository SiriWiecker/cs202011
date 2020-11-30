using System;

namespace RefreshDag4
{
    class Program
    {
        // Global navngivningsstandard til delegates: angive argumenterne og returværdien.
        delegate void DelegateStringVoid(string txt); // definering af en delegeate, som har en masse metoder på som ligger på klassen
        // en masse referencer til klassen

        static void Main(string[] args)
        {
            Test("Hello world");

            // Nu vil jeg gerne have en instans af sådan en klasse
            DelegateStringVoid a = new DelegateStringVoid(Test); // man skal have en reference til en funktion, derfor skriver man lig med new Delegate1();
            // Nu har vi et objekt a som indeholder reference til en masse metoder
            // a peger på et objekt der peger/har en reference på en liste af metoder

            // Her kalder vi den indirekte så vi får samme resultat
            a.Invoke("Hello world");


        }

        public static void Test(string a)
        {
            Console.WriteLine("* " + a);
        }

        // kalder met oden indirekte indirekte
        //public static void Test2(DelegateStringVoid f)
        //{
        //    f.Invoke("Hello world");
        //}
    }
}
