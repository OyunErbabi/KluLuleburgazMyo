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
            
            string a = "Bilgisayar";
            string b=string.Copy(a); // stringi kopyalar
            string c="Programcılığı";
            string d=String.Concat(a," ",c); // parametre olarak verilen stringleri birleştirir
            string e = "Test";
            e=string.Empty; // stringi boşaltır


            Console.WriteLine(a); // Bilgisayar
            Console.WriteLine(b); // Bilgisayar
            Console.WriteLine(c); // Programcılığı
            Console.WriteLine(d); // Bilgisayar Programcılığı
            Console.WriteLine(e); // Boş string

            Console.ReadLine();

        }
    }
}
