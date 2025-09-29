using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    internal class Program
    {
         string ad;

        private void isimal(string isim)
        {
            ad = isim;
            Console.WriteLine("Adınız: " + ad);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program yeni = new Program();
            yeni.isimal("Ahmet");

        }
    }
}
