using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3
{
    internal class Program
    {
        int topla;

        public void toplam(int topla)
        {
            this.topla += topla;
        }


        public void ekranaYaz()
        {
            Console.WriteLine("Toplam: " + topla);
        }

        static void Main(string[] args)
        {
            Program ornek = new Program();
            ornek.toplam(10);
            ornek.toplam(20);
            ornek.ekranaYaz();
            Console.ReadLine();
        }
    }
}
