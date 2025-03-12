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

            Random rand = new Random();
            int topadet = 0, tekadet = 0, sayi;

            while (true)
            {
                sayi = rand.Next(1, 150);
                topadet++;
                
                if (sayi % 2 == 0) continue;
                Console.WriteLine(sayi);
                tekadet++;
                if (sayi == 100) break;
            }
            Console.WriteLine("Toplam Sayı Adeti: " + topadet);
            Console.WriteLine("Tek Sayı Adeti: " + tekadet);
            Console.ReadKey();
        }
    }
}
