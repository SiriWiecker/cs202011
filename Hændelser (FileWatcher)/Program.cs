using System;

namespace Hændelser__FileWatcher_
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\tmp", "*.txt");
            //w.EnableRaisingEvents = true;
            //w.Changed += (s, e) => Console.WriteLine("Filen {0} er rettet");
            //w.Created += (s, e) => Console.WriteLine("Fil oprettet", e.FullPath);
            //do { } while (true);


            using (System.IO.FileSystemWatcher w =
                new System.IO.FileSystemWatcher(@"c:\tmp", "*.txt"))
            {
                w.EnableRaisingEvents = true;
                w.Changed += W_Changed;
                w.Created += (s, e) => Console.WriteLine("Oprettet " + e.FullPath);
                do { } while (true);
            }
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Ændret" + e.Name);
        }

    }
}
