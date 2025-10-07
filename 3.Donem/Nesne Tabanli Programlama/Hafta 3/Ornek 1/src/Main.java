import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        /*
        Scanner input = new Scanner(System.in);
        System.out.println("Saniye Değeri: ");
        int saniye = input.nextInt();
        int dakika = saniye/60;
        int saat = dakika/60;
        dakika = dakika%60;
        saniye = saniye%60;
        System.out.println("Saat: " + saat);
        System.out.println("Dakika: " + dakika);
        System.out.println("Saniye: " + saniye);
         */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Yıl: ");
        int yil = input.nextInt();
        if(yil % 400==0 || (yil%4==0 && yil%100!=0) )
        {
          System.out.println(yil+ "Artık yıldır");
        }
        else
        {
            System.out.println(yil+ "Artık Değildir");
        }
        */



        /*
        Scanner input = new Scanner(System.in);
        System.out.print("a: ");
        int a = input.nextInt();
        System.out.print("b: ");
        int b = input.nextInt();
        System.out.print("c: ");
        int c = input.nextInt();

        if(a+b>c && a+c>b && b+c>a)
        {
            System.out.println("Üçgen Oluşur");
        }
        else
        {
            System.out.println("Üçgen Oluşmaz");
        }
         */


        /*
        float sonfiyat;
        Scanner input = new Scanner(System.in);
        System.out.print("Fiyat: ");
        float fiyat = input.nextFloat();

        if(fiyat>750)
        {
            sonfiyat=fiyat*1.08f;
        }
        else {
            sonfiyat=fiyat*1.18f;
        }

        System.out.println("Sonfiyat: "+sonfiyat);

         */


        /*
        Scanner input = new Scanner(System.in);
        System.out.println("Satış adedini giriniz: ");
        int satismiktari=input.nextInt();
        int tutar;
        if(satismiktari<50)
        {
            tutar=15+(satismiktari*2);
            System.out.println("Tutar: "+tutar);
        }
        else
        {
            tutar=20+(50*2)+(satismiktari-50)*3;
            System.out.println("Tutar: "+tutar);
        }
         */


        /*
        Scanner input = new Scanner(System.in);
        System.out.println("Paket Ağırlını Giriniz: ");
        float kg = input.nextFloat();
        float tutar;

        if(kg<5)
            tutar = 8.7f+kg*2.7f;
        else
            tutar = 11.3f+(5*4.1f)+((kg-5)*4.9f);

        System.out.println("Tutar: "+tutar+" TL");
        */


        /*
        Scanner input = new Scanner(System.in);
        System.out.println("x değerini giriniz");
        float x = input.nextFloat();
        float fx,gx;

        if(x>0)
        {
            fx=1/(3*x);
            gx=1/(1+1/x);
        }
        else
        {
            fx=1/(1+x*x);
            gx=1/(1+x+(x*x));
        }

        System.out.println("f(x): "+fx);
        System.out.println("g(x): "+gx);
        */


        float bademtl=4.5f;
        float ceviztl=14.7f;
        float kajutl=23.1f;
        float maliyet=(bademtl*12)+(ceviztl*25)+(kajutl*40);


        float satistutari= ((bademtl*1.5f)*12)+((ceviztl*1.4f)*25)+((kajutl*1.6f)*40);
        float toplamkar= satistutari-maliyet;

        if(toplamkar>500){
            System.out.println("KİRA ÖDENEBİLİR");
        }
        else {
            System.out.println("KİRA ÖDEYEMEZSİNİZ");
        }

        System.out.println("Maliyetiniz: "+maliyet);
        System.out.println("Satış Tutarınız: "+satistutari);
        System.out.println("Toplam Kar: "+toplamkar);

    }
}
