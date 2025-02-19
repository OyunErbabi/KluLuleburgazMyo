using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            byte notdegeri;
            Console.Write("Notunuzu Giriniz: ");
            notdegeri = byte.Parse(Console.ReadLine());
            if (notdegeri < 50)
            {
                Console.WriteLine("Kaldınız");
            }
            else
            {
                Console.WriteLine("Geçtiniz");
            }
            Console.ReadKey();
        }
        */


        /*
        static void Main(string[] args) 
        {

            double urunfiyati1, urunfiyati2, toplam, odeme, indirim;
            Console.Write("1. Ürünün Fiyatını Giriniz: ");
            urunfiyati1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Ürünün Fiyatını Giriniz: ");
            urunfiyati2 = Convert.ToDouble(Console.ReadLine());
            toplam = urunfiyati1 + urunfiyati2;
            odeme = toplam;
            if(toplam > 100)
            {

                if (urunfiyati1 < urunfiyati2)
                {
                    indirim = urunfiyati1 * 0.4;
                }
                else
                {
                    indirim = urunfiyati2 * 0.4;
                }
                odeme = toplam - indirim;

            }
            Console.WriteLine("Odenecek Toplam Tutar: " + odeme);
            Console.ReadLine();
        }
        */


        /*
        ///Klavyeden girilen sayinın secime göre kare küp ve karekökünü hesaplayan program        

        static void Main(string[] args)
        {
            int sayi, secim;
            double sonuc;
            Console.Write("Bir Sayı Giriniz: ");
            sayi= Convert.ToInt32(Console.ReadLine());
            Console.Write("1-Kare\n2-Küp\n3-Karekök \n\n Seciminz :");
            secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                sonuc = Math.Pow(sayi, 2);
                Console.Write("Girilen Sayının Karesi: " + sonuc);
            }
            else if (secim == 2)
            {
                sonuc = Math.Pow(sayi, 3);
                Console.Write("Girilen Sayının Küpü: " + sonuc);
            }
            else if (secim == 3)
            {
                sonuc = Math.Sqrt(sayi); //sonuc = Math.Pow(sayi, 0.5); //sonuc = Math.Pow(sayi, 1/2);
                Console.Write("Girilen Sayının Karekökü: " + sonuc);
            }
            else
            {
                Console.Write("Hatalı Seçim Yaptınız");                
            }
            
            Console.ReadLine();

        }
        */


        /*
        static void Main(string[] args)
        {
            int secim;
            Baslangic:
            Console.Write("(1-7) arasında bir gün degeri giriniz: ");
            secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default:
                    Console.WriteLine("Hatalı Giriş!! Tekrar Deneyin");
                    goto Baslangic;
            }
            Console.ReadLine();
        }
        */


    }
}
