using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b,c;
            a = "Bilgisayar";
            b="Programcılığı";
            Console.WriteLine(b);
            

            c=String.Concat(a," ",b); // iki stringi birleştirir
            Console.WriteLine(c);

            b=string.Empty; // stringi boşaltır



            Console.ReadLine();

        }
    }
}
