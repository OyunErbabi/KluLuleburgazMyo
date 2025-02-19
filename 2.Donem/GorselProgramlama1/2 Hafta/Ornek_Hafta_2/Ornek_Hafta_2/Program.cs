using System;


static void Main()
{

    byte notdegeri;
    Console.Write("Notunuzu Giriniz: ");
    notdegeri = byte.Parse(Console.ReadLine());
    if(notdegeri < 50)
    {
        Console.WriteLine("Kaldınız");
    }
    else
    {
        Console.WriteLine("Geçtiniz");
    }
    Console.ReadKey();
}
