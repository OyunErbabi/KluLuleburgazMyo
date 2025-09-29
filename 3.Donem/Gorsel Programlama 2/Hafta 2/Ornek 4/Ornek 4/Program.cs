using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say;
            Console.WriteLine("Bir sayi giriniz:");
            say = Convert.ToInt32(Console.ReadLine());

            Class1 nesne = new Class1();
            nesne.SayiBelirle(say);
            Console.WriteLine("Girdiginiz sayi: " + nesne.SayiAl());
            Console.ReadKey();

        }
    }
}
