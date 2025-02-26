using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i=0;

            /*
            while (true)
            {
                for (i = 1; i <= 10000; i++)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            while (true)
            {
                i++;
                Console.WriteLine(i);
                if (i == 10000)
                {
                    i = 0;
                }
            }
            */

            /*
            for (i = 1; i <= 10000; i++)
            {
                
                if (Console.KeyAvailable == false)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    break;
                }

                if (i == 10000)
                {
                    i = 0;
                }
            }
            */


            /*
            //Bilgisayarın 1 ile 100 arasinda tuttugu 20 adet sayiyi ekrana yazdiran ve bu sayilarin kac tanesini tek ve cift oldugunu bulan program

            int i, rasgele,tekadet = 0, ciftadet = 0;
            Random rnd = new Random();
            i = 1;
            while (i <= 20)
            {
                rasgele = rnd.Next(1, 101); // COK ONEMLI EGER 100 SAYISINI DAHIL ETMEK ISTIYORSANIZ SAYININ 1 FAZLASI GIRILMESI GEREKIYOR YANI 101 YANI BU SATIR 1 DAHIL VE 100 DAHIL TUM SAYILARIN ARASINDAN RANDOM BIRINI GETIRIR
                
                Console.WriteLine(rasgele);
                if (rasgele % 2 == 0)
                {
                    ciftadet++;
                }
                else
                {
                    tekadet++;
                }
                i++;

                
            }
            Console.WriteLine("Tek Sayi Adedi: " + tekadet);
            Console.WriteLine("Cift Sayi Adedi: " + ciftadet);
            Console.ReadLine();
            */

            //Kullanici E veya e harfina bastigi taktirde sayi girisine devam eden, baska bir harfe bastiginda o ana kadar girilen sayilarin toplamini hesaplayan program

            int toplam = 0, sayi,i=1;
            char cevap;

            /*
            while (true)
            {
                i++;
                Console.WriteLine("Sayi Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi; //toplam += sayi;
                Console.WriteLine("Sayi girisine Devam Etmek Icın E/e Harfine Basiniz :");
                cevap = Convert.ToChar(Console.ReadLine());
                if (cevap != 'E' && cevap != 'e')
                {
                    break;
                }
            }
            */

            do
            {
                i++;
                Console.WriteLine("Sayi Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi; //toplam += sayi;
                Console.WriteLine("Sayi girisine Devam Etmek Icın E/e Harfine Basiniz :");
                cevap = Convert.ToChar(Console.ReadLine());

            }
            while (cevap == 'E' || cevap == 'e');

            Console.WriteLine("Girilen Sayilarin Toplami: " + toplam);
            Console.ReadLine();


        }
    }
}
