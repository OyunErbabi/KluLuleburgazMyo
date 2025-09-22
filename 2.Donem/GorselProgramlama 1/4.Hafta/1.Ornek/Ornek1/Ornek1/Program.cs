using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        /*
        // 1'den başlayarak kullanıcının girdiği sayıya kadar olan sayılardan 3'ün katı olanları ekrana yazdırıp, bu sayıların adedini ve toplamını ekrana yazdıran program.
        static void Main(string[] args)
        {
            int i = 1, sayi, adet = 0, toplam = 0;

            Console.Write("Bir Sayi Giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            while(i<sayi)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                    adet++;
                    toplam += i;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("3un Kati Olan Sayilarin Adedi    : " + adet);
            Console.WriteLine("3un Kati Olan Sayilarin Toplami  : " + toplam);
            Console.ReadKey();
        }
        */

        /*
        //Şekilli X Yazan kod
        static void Main(string[] args)
        {
            string kelime;
            int i;
            Console.Write("Bir Kelime Giriniz : ");
            kelime = Console.ReadLine();
            for (i = 0; i <=20; i++)
            {
                Console.SetCursorPosition(i+25, i);
                Console.Write(kelime);
                Console.SetCursorPosition(45-i,i);
                Console.Write(kelime);
            }
            Console.ReadKey();
        }
        */

        static void Main(string[] args)
        {
            string kelime;
            int i,j;
            Console.Write("Bir Kelime Giriniz : ");
            kelime = Console.ReadLine();
            Console.Clear();

            for (i = 1;i<= 2; i++)
            {
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                for(j = 0; j <= kelime.Length - 1; j++)
                {
                    Console.Write(kelime[j]);
                    System.Threading.Thread.Sleep(200);
                }

                
                
                Console.Clear();


                if (i == 2) i = 0;
            }


            Console.ReadKey();
        }
    }
}
