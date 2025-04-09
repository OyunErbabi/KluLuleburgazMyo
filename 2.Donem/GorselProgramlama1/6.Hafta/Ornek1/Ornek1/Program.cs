using System;
using System.Collections;
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
            #region Ornek2
            /*
            Array okulturleri = Array.CreateInstance(typeof(string), 4);
            string[] okulturu = (string[])okulturleri;
            okulturu[0] = "Genel Lise";
            okulturu[1] = "Fen Lisesi";
            okulturu[2] = "Meslek Lisesi";
            okulturu[3] = "Teknik Lise";

            
            //okulturu.SetValue("Genel Lise", 0);
            //okulturu.SetValue("Fen Lisesi", 1);
            //okulturu.SetValue("Meslek lise", 2);
            //okulturu.SetValue("Teknik Lise", 3);
            

            for (int i = 0; i < okulturu.Length; i++)
            {
                Console.WriteLine(okulturu.GetValue(i));
            }
            Console.ReadLine();
            */
            #endregion

            #region Ornek3
            /*
            string[] okulturu = { "Anadolu", "Meslek", "Fen"};
            string ad = "Ali";
            Type tip;
            tip = okulturu.GetType();
            Console.WriteLine(tip.IsArray);
            tip = ad.GetType();
            Console.WriteLine(tip.IsArray);
            Console.ReadLine();
            */
            #endregion

            #region Ornek4
            /*
            string aranan;
            string[] isimler = new string[4];
            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Ayşe";
            isimler[3] = "Fatma";
            Console.WriteLine("Aranacak ismi giriniz:");
            aranan = Console.ReadLine();
            
            if(isimler.Contains(aranan)==false)
            {
                Console.WriteLine("Aradığınız isim listede mevcut değil.");
            }
            else
            {
                Console.WriteLine("Aradığınız isim listede mevcut.");
            }
            */
            #endregion

            #region Ornek5
            /*
            int indexno;
            string aranan;
            Array okul = Array.CreateInstance(typeof(string), 6);
            okul.SetValue("Genel Lise", 0);
            okul.SetValue("Fen Lisesi", 1);            
            okul.SetValue("Meslek Lisesi", 2);
            okul.SetValue("Teknik Lise", 3);
            okul.SetValue("Anadolu Lisesi", 4);

            Console.Write("Aranacak Değeri Gir: ");
            aranan = Console.ReadLine();
            //indexno = Array.LastIndexOf(okul, aranan.ToString()); // yok ise -1 döner
            indexno = Array.BinarySearch(okul, aranan.ToString()); // yok ise - değer döner //Alfabetik sıra varken düzgün çalışır

            if (indexno <0)
            {
                Console.WriteLine("Aradığınız değer listede mevcut değil.");
            }
            else
            {
                Console.WriteLine("Bulundu "+indexno+". sirada");
            }
            */
            #endregion

            #region Ornek5
            /*
            ArrayList isimler = new ArrayList();
            //isimler.Add("Ahmet");
            //isimler.Add("Mehmet");
            //isimler.Add("Ali");
            //isimler.Add("Veli");

            //isimler.Add("23");
            //isimler.Add("115");
            //isimler.Add("9");
            //isimler.Add("72");

            isimler.Add(23);
            isimler.Add(115);
            isimler.Add(9);
            isimler.Add(72);

            //isimler.Insert(1, "Ayşe")
            //isimler.Remove("Mehmet");
            //isimler.RemoveAt(1);
            isimler.Sort();
            isimler.Reverse();

            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.ReadLine();
            */
            #endregion

            #region Ornek6

            ArrayList diller = new ArrayList();
            diller.Add("VB.Net");
            diller.Add("C#");
            diller.Add("Asp.Net");
            ArrayList diller2 = new ArrayList();
            diller2.Add("Python");
            diller2.Add("Java");
            diller2.Add("C++");
            diller.InsertRange(1,diller2); //diller.AddRange(diller2);
            //diller2 = diller.GetRange(0, 2);

            diller.RemoveRange(0, 2); //diller.RemoveAt(0);

            foreach (string eleman in diller)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadKey();

            #endregion
        }
    }
}
