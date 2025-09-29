using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say;
            Console.Write("Bir sayi giriniz:");
            say = Convert.ToInt32(Console.ReadLine());
            Class1 nesne = new Class1();
            nesne.sahteozellik = say;
            Console.WriteLine("Ozellik degeri:" + nesne.sahteozellik);
            Console.ReadLine();

        }
    }
}
