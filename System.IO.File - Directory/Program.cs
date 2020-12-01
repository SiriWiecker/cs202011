using System;
using System.IO;

namespace System.IO.File___Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.Exists(@"c:\tmp"));
            Console.WriteLine(Directory.GetFiles(@"c:\tmp"));
            
        }
    }
}
