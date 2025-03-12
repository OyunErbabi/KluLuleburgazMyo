using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kelime;
            Console.WriteLine("Bir Kelimeyi Giriniz: ");
            kelime = Console.ReadLine();

            for (int i = 0; i < kelime.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(kelime[j] + " " );

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
