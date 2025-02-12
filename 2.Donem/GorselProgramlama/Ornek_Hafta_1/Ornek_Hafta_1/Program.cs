using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Hafta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string numara1, numara2;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            numara1 = Console.ReadLine();
            Console.WriteLine("İkinci sayıyı giriniz: ");
            numara2 = Console.ReadLine();
            Console.WriteLine("Girilen Sayilar {0} ve {1}", numara1, numara2);
            Console.WriteLine();
            Console.WriteLine("Girilen Sayilar " + numara1 + " ve " + numara2);
            Console.ReadKey();
            */

            /*
            int numara1, numara2;
            Console.WriteLine("Birinci sayıyı giriniz: ");
            numara1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            numara2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen Sayilar {0} ve {1}", numara1, numara2);
            Console.ReadKey();
            */

            /*
            const double pi = 3.1428;
            double yaricap, alan, cevre;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Write("Yariacapi giriniz: ");
            yaricap = Convert.ToDouble(Console.ReadLine());
            cevre = 2 * pi * yaricap;
            alan = pi * Math.Pow(yaricap, 2);
            Console.WriteLine("Dairenin Çevresi = "+ cevre);
            Console.WriteLine("Dairenin Alanı = " + alan);
            Console.ResetColor();
            Console.ReadKey();
            */


            /*
            char karakter;
            Console.Write("Bir tusa basarak ardindan Enter'e basiniz: ");
            karakter = Convert.ToChar(Console.Read());
            Console.Write("Basilan Tus: " + karakter);
            Console.ReadKey();
            */

            /*
            Console.Write("Bir tusa basiniz: ");
            ConsoleKeyInfo tuss = Console.ReadKey();
            Console.Write("\n"+tuss.Key.ToString()+" Tusuna Bastiniz");
            Console.ReadKey();
            */


            string ad, soyad;
            Console.Write("Adinizi Giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadinizi Giriniz: ");
            soyad = Console.ReadLine();            
            Console.Clear();
            Console.WriteLine("Ekrana yazdirmak icin F2, Cikmak icin ESC tusuna basiniz");

            ConsoleKeyInfo tusbilgi = Console.ReadKey();
            if(tusbilgi.Key == ConsoleKey.F2)
            {
                Console.WriteLine(ad + " " + soyad);
                Console.ReadLine();
            }
            else if(tusbilgi.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Hatali Tuslama Yaptiniz");
                Console.ReadLine();
            }
            
        }
    }
}
