using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string yazi = "";
            DateTime BaslangicZamani;
            DateTime BitisZamani;
            BaslangicZamani = DateTime.Now;
            for (i = 0; i < 1000000; i++) // bir milyon karakter bilgisayarını kilitleyebilir!!!
            {
                yazi = yazi + 1;
            }
            BitisZamani = DateTime.Now;
            Console.WriteLine("String sinifi baslangic: "+BaslangicZamani.ToString());
            Console.WriteLine("String sinifi bitis: " + BitisZamani.ToString());
            Console.WriteLine();
            StringBuilder sb = new StringBuilder();
            BaslangicZamani = DateTime.Now;
            for (i = 0; i < 1000000; i++)
            {
                sb.Append(i.ToString());
            }
            BitisZamani = DateTime.Now;
            Console.WriteLine("StringBuilder sinifi baslangic: " + BaslangicZamani.ToString());
            Console.WriteLine("StringBuilder sinifi bitis: " + BitisZamani.ToString());

            Console.ReadLine();
        }
    }
}
