using System;
using System.Linq;
using System.CodeDom.Compiler;
// Microsoft.CSharp.CsharpCodeprovider;

namespace Ø_150_1__Linq_
{
    class Program
    {
        // public virtual System.CodeDom.Compiler.CompilerResults CompileAssemblyFromFile(System.CodeDom.Compiler.CompilerParameters options, params string[] fileNames);
        // 


        static void Main(string[] args)
        {
            int[] a = { 1, 5, 7, 2, 6, 7, 3, 5, 7, 8, 2, 5, 4, 1 };

            //Brug Count() til at finde og udskrive antal
            //Brug Count(...) til at finde og udskrive hvor mange 7'ere der er
            //Brug Sum() til at finde og udskrive summen
            //Brug Average() til at finde og udskrive gennemsnit
            //Brug OrderBy til at sortere og udskrive array(brug string.join metoden til at udskrive array)
            //Brug Where til at finde og udskrive tal > 5(brug string.join metoden til at udskrive array)
            //Brug Take til at finde og udskrive de første 5 tal(brug string.join metoden til at udskrive array)
            //Brug Skip og Take til at finde og udskrive tal nr 6 - 10(brug string.join metoden til at udskrive array)


            Console.WriteLine(a.Count());

            string text = System.IO.File.ReadAllText(@"C:\Users\Admin\source\repos\cs202011\Ø 150-1 (Linq)\Code\code.txt");
            Console.WriteLine(text);

            

            var countSevens = a.Where(i => i == 7).Count();
            Console.WriteLine(countSevens);

            Console.WriteLine(a.Sum());
            Console.WriteLine(a.Average());
            Console.WriteLine(string.Join(",", a.OrderBy(i => i)));
            Console.WriteLine(string.Join(' ', a.Where(i => i > 5)));
            Console.WriteLine(string.Join(' ', a.Take(5).ToList()));
            Console.WriteLine(string.Join(' ', a.Skip(5).Take(5).ToList()));
        }
    }
}
