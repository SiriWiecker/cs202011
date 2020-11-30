using System;

namespace Hændelser__KreditMax_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(600);
            k.Køb(200);
            k.Køb(1000);
        }
    }

    public class Kunde
    {
        // I klassen skal der være en hændelse (event) kaldet KreditOverskredet. Den skal kaldes såfremt kreditmax overskrides. 
        // Hændelsen skal blot være af typen EventHandler, der som argument tager en sender (object) og eventargs (System.EventArgs). 

        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
            this.Saldo -= værdi;
            if (Saldo < KreditMax)
            {
                KreditOverskredet?.Invoke(this, new EventArgs());
            }
        }
    }
}
