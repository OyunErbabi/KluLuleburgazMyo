import java.util.Locale;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Kenar 1: ");
        int k1 = input.nextInt();
        System.out.print("Kenar 2: ");
        int k2 = input.nextInt();
        System.out.print("Kenar 3: ");
        int k3 = input.nextInt();

        if(k1 == k2 && k2 == k3)
        {
            System.out.println("Eşkenar");
        }
        else if(k1 == k2 || k1 == k3 || k2 == k3)
        {
            System.out.println("İkizkenar");
        }
        else
        {
            System.out.println("Çeşitkenar");
        }
         */

        /*
        //vki= kilo/boy*boy

        Scanner input = new Scanner(System.in);
        System.out.println("Kilo (kg):");
        float kilo = input.nextFloat();
        System.out.println("Boy (cm):");
        float boy = input.nextFloat();

        float vki=kilo/(boy*boy);

        String Durum;
        if(vki<18.5f){
            Durum="Zayif";
        }
        else if(vki>=18.5f && vki<25f)
        {
            Durum="Normal";
        }
        else if(vki>=25f && vki<30f)
        {
            Durum="Kilolu";
        }
        else if(vki>=30f && vki<35f)
        {
            Durum="Obez";
        }
        else
        {
            Durum="Asiri Obez";
        }

        System.out.println("Vki: "+ vki+" Bu Degere gore durumunuz "+Durum);
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Hiz: ");
        int hiz = input.nextInt();
        int ceza;

        if(hiz>=90 && hiz<=110)
        {
            ceza = ((hiz*7)/2)+hiz;
        }
        else if(hiz>110 && hiz<=130)
        {
            ceza = ((hiz*7))+(hiz/2);
        }
        else if (hiz>130 && hiz<=150)
        {
            ceza = (hiz*hiz)/4;
        } else if (hiz>150 && hiz<=170)
        {
            ceza = (hiz*35)+hiz;
        }
        else {
            ceza = hiz*(hiz+50);
        }
        System.out.println("Ceza : "+ceza);
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Ay: ");
        int ay = input.nextInt();
        int gun=0;
        if(ay==1 || ay==3 || ay==5 || ay==7 || ay==8 || ay==10 ||ay==12)
        {
            gun = 31;
        }
        else if (ay==4 || ay==6 || ay==9 || ay==11)
        {
            gun=30;
        }
        else if (ay==2)
        {
            System.out.println("Yil: ");
            int yil = input.nextInt();
            if((yil%4==0 && yil%100 !=0)||(yil%400==0))
            {
                gun=29;
            }
            else
            {
                gun=28;
            }
        }
        else
        {
            System.out.println("Gecersiz Sayi Girdiniz.");
        }

        System.out.println("Girilen Ay: "+gun);
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Kenar-1: ");
        int k1 = input.nextInt();
        System.out.print("Kenar-2: ");
        int k2 = input.nextInt();
        System.out.print("Kenar-3: ");
        int k3 = input.nextInt();
        int a,b,c;
        c=k1;
        if(k2>c)
        {
            c=k2;
        }
        if(k3>c)
        {
            c=k3;
        }

        if(c==k1)
        {
            a=k2;
            b=k3;
        }
        else if (c==k2)
        {
            a=k1;
            b=k3;
        }
        else
        {
            a=k1;
            b=k2;
        }

        if((c*c)== (a*a)+(b*b))
        {
            System.out.println("Dik ucgendir.");
        }
        else
        {
            System.out.println("Dik ucgen degildir.");
        }

         */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Sayi-1: ");
        int s1 = input.nextInt();
        System.out.print("Sayi-2: ");
        int s2 = input.nextInt();
        System.out.print("Sayi-3: ");
        int s3 = input.nextInt();

        if(s1>s2 && s1>s3)
        {
            if(s2>s3)
            {
                System.out.println("S1>S2>S3");
            }
            else
            {
                System.out.println("S1>S3>S2");
            }
        }
        else if(s2>s1 && s2>s3){
            if(s1>s3)
            {
                System.out.println("S2>S1>S3");
            }
            else
            {
                System.out.println("S2>S3>S1");
            }
        }
        else
        {
            if(s1>s2)
            {
                System.out.println("S3>S1>S2");
            }
            else
            {
                System.out.println("S3>S2>S1");
            }

        }
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.println("A:");
        int a = input.nextInt();
        System.out.println("B:");
        int b = input.nextInt();
        System.out.println("C:");
        int c = input.nextInt();

        double x,x1,x2,delta;

        delta=(b*b) - (4*a*c);
        x=(-1*b)*(2*a);
        x1=(-1*b)+Math.sqrt(delta)/(2*a);
        x2=(-1*b)-Math.sqrt(delta)/(2*a);

        System.out.println("Delta: "+delta);
        if(delta>0)
        {
            System.out.println("X1= "+x1 +" X2= "+x2);
        }
        else if(delta<0)
        {
            System.out.println("Kok yok");
        }
        else
        {
            System.out.println("X= "+x);
        }
        */

        /*
     Scanner input = new Scanner(System.in);
     System.out.println("Mesafeyi Giriniz: ");
     int mesafe = input.nextInt();
     System.out.println("Yasinizi Giriniz: ");
     int yas = input.nextInt();
     System.out.println("Yolculuk Tipini Seciniz (1-Tek Yon, 2-Gidis-Donus): ");
     int yon = input.nextInt();

     double normalfiyat,yasindirimi,tipindirimi;

     if(mesafe>0 && yas>0 && (yon==1 || yon==2))
     {
         normalfiyat = mesafe * 1.25;

         if(yas<12)
         {
            yasindirimi = normalfiyat * 0.5;
         }
         else  if(yas>=12 && yas<=24)
         {
             yasindirimi = normalfiyat * 0.1;
         }
         else if (yas>=65){
             yasindirimi = normalfiyat * 0.3;
         }
         else
         {
             yasindirimi=0;
         }

         //normalfiyat = normalfiyat - yasindirimi;
         normalfiyat -= yasindirimi;


         if(yon==2)
         {
             tipindirimi = normalfiyat * 0.2;
             normalfiyat = (normalfiyat + tipindirimi)*2;
         }
         System.out.println("Bilet Ucreti: "+normalfiyat+ " TL");
     }
     else
     {
        System.out.println("Hatali Veri Girisi");
     }
     */


        Scanner input = new Scanner(System.in);
        System.out.print("Cinsiyetinizi Girin (Kadin/Erkek): ");
        String cinsiyet = input.nextLine();
        System.out.print("Urun Kilogram Fiyatini Girin: ");
        int kilogram = input.nextInt();
        System.out.print("Alinacak Miktari Gram Cinsinden Girin: ");
        int miktar = input.nextInt();

        int cinsiyetTipi = 0; //1-erkek 2-kadin

        cinsiyet = cinsiyet.toLowerCase(Locale.ENGLISH); // Turkce karakter sorun yapabilir

        if(cinsiyet.equals("erkek"))
            cinsiyetTipi = 1;
        else if(cinsiyet.equals("kadin"))
            cinsiyetTipi = 2;


        double toplamfiyat = (miktar/1000D) *kilogram;
        if(cinsiyetTipi==1)
            toplamfiyat = toplamfiyat -(toplamfiyat*0.1);
        else if (cinsiyetTipi==2)
            toplamfiyat = toplamfiyat -(toplamfiyat*0.2);

        if(miktar>=100 && miktar<=250)
        {
            if(cinsiyetTipi==1)
            {
                toplamfiyat = toplamfiyat -(toplamfiyat*0.025);
            }
            else if (cinsiyetTipi==2)
            {
                toplamfiyat = toplamfiyat -(toplamfiyat*0.035);
            }
        }
        else if(miktar>250 && miktar<=500)
        {
            if(cinsiyetTipi==1)
            {
                toplamfiyat = toplamfiyat -(toplamfiyat*0.03);
            }
            else if (cinsiyetTipi==2)
            {
                toplamfiyat = toplamfiyat -(toplamfiyat*0.04);
            }
        }
        else if (miktar>500)
        {
            toplamfiyat = toplamfiyat -(toplamfiyat*0.045);
        }

        System.out.print("Odenecek Tutar: "+toplamfiyat+" TL");

    }
}
