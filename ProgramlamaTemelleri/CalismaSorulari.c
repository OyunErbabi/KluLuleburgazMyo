/*1-Yaricapi girilen bir dairenin cevre ve alanini hesaplayarak ekrana yazdiran programi yaziniz
DC =2*pi*r ve DA = pi*r^2*/

/*
#include <stdio.h>
#include <math.h>

main()
{
	
	float yaricap,cevre,alan,pi=3.14;
	printf("Yaricap Gir :");
	scanf("%f",&yaricap);
	
	alan=pi*pow(yaricap,2);
	cevre=2*pi*yaricap;
	

	printf("\nAlani : %f",alan);
	printf("\nCevresi : %f",cevre);
	
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*2-Klavyeden girilen uç adet X, Y ve Z sayilarinin en kucugunu bulan ve ekrana yazdiran programi
if komut yapisini kullanarak yaziniz. ( || (veya) ile && (ve) operatorlerini kullanmayiniz)
*/

/*
#include <stdio.h>

main()
{
	int x,y,z,enk;
	
	printf("X i Gir :");
	scanf("%d",&x);
	printf("Y i Gir :");
	scanf("%d",&y);
	printf("Z i Gir :");
	scanf("%d",&z);
	
	
	if(x<y)
	{
		if(x<z)
		{
			printf("En Kucuk Sayi X tir");
			enk=x;			
		}
		else
		{
			printf("En Kucuk Sayi Z dir");
			enk=z;
		}		
	}
	else 
	{
		if(y<z)	
		{
			printf("En Kucuk Sayi Y dir");
			enk=y;
		}
		else 
		{
			printf("En Kucuk Sayi Z Dir");
			enk=z;
		}
	}
	
	printf("\nEn Kucuk Sayi : %d",enk);
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*3-Klavyeden urun tipi, adedi ve birim fiyati girilecek. Kalem icin KDV %10, Defter icin %15
olarak birim fiyata eklenerek adede gore toplam fiyat hepsaplanarak ekrana yazdirilacak programi 
switch-case komut yapisini kullanarak yaziniz.*/
/*
#include <stdio.h>

main()
{
	int adet,secim,birimFiyat;
	float kdv, toplamFiyat;
	printf("Urunu Seciniz :\n1-Kalem\n2-Defter\n");
	scanf("%d",&secim);
	
	switch(secim)
	{
		case 1: 
			kdv = 10;
			break;
		case 2:
			kdv = 15;
			break;
		default:
			printf("Gecersiz Urun Girdiniz!");
			break;
	}
	
	printf("Adedi Giriniz: ");
	scanf("%d",&adet);
	
	printf("Birim Fiyati Giriniz: ");
	scanf("%d",&birimFiyat);
	
	toplamFiyat = adet * (birimFiyat * (1+(kdv/100)));
	
	printf("Toplam Fiyat : %.2f",toplamFiyat);
	
	
	
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*4-A sehrinden B sehrine gidecek bir yolcu, ya taksiye ya da dolmusa binecektir.
Taksi km basina 1 lira, dolmus ise 5 km ye kadar 2 lira almaktadir. Yolcu hangi aracla
gitmek istedigini sececek ve kac km lik yok gidecegini klavyeden girecektir. Buna gore
yolcunun bindigi aractan inerken odemesi gereken tutarý hesaplayan programý yazýnýz.*/

/*
#include <stdio.h>

main()
{
	int arac;
	float mesafe,tutar;
	printf("Tercih Edilen Arac : \n1-Taksi\n2-Dolmus\n");
	scanf("%d",&arac);
	printf("Gidilecek Mesafeyi(KM) Giriniz :");
	scanf("%f",&mesafe);
	
	if(arac==1)
	{
		tutar = mesafe;
	}
	else if(arac==2)
	{
		if(mesafe<=5)
		{
			tutar = 5;
		}	
		else 
		{
			tutar = mesafe/5;
		}
	}
	
	printf("Odeyeceginiz Tutar : %.2f",tutar);
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*5-Klavyeden girilen sayinin faktoriyelin hesaplayan programi 
while dongusu ile i++ kullanmadan i-- kullanarak yaziniz.*/

/*

#include <stdio.h>

main()
{
	int i,sayi,fakt= 1;
	
	printf("Faktoriyeli Alinacak Sayiyi Giriniz : \n");
	scanf("%d",&sayi);
	i = sayi;
	
	
	while(i>0)
	{
		fakt = i * fakt;		
		i--;	
	}
	
	printf("Sonuc : %d",fakt);
	
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*6-Klavyeden 50 tane sayi girilerek toplamini hesaplayip ekrana yazdiracak programi
for dongusu ile yaziniz. Eger sayý 0 ise donguden cikacak ve o ana kadar girilen sayilarin toplamini
ekrana yazacak.*/


/*
#include <stdio.h>

main()
{
	int toplam=0,i,sayi;
	
	for(i=1;i<=50;i++)
	{
		printf("%d.Sayiyi Giriniz :\n",i);
		scanf("%d",&sayi);
		toplam = toplam+sayi;
		
		if(sayi==0) break;
	}
	
	printf("Toplam : %d",toplam);
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*7-Soruda gosterilen matematiksel fonksiyonu klavyeden girilen sayý ile hesaplayan programi 
herhangi bir dongu kullanarak yaziniz.*/

/*

#include <stdio.h>
#include <math.h>
main()
{
	int sayi,i,toplam=0;
	
	printf("Sayiyi Giriniz :\n");
	scanf("%d",&sayi);
	
	for(i=0;i<=sayi;i++)
	{
		toplam = toplam + pow(i,2);
	}
	
	printf("\nSonuc : %d",toplam);
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*8-Bir agacin boyu klavyeden girileceki her yil yillik yagis orani girilecek.
Yagis orani %50'nin altindaysa agacin boyu %15, yillik yagis orani %50 ve uzerindeyse
agacin boyu %25 uzayacak. 20 yil sureyle agacin boyunu ekrana yazdiran programi do-while
dongu yapisini kullanarak yaziniz.*/

/*

#include <stdio.h>

main()
{
	int YagisOrani,yil=0;
	float AgacBoyu=0;
	
	printf("Agacin Boyunu Giriniz: \n");
	scanf("%f",&AgacBoyu);
	do
	{
		printf("\n%d.Yilin Yagis Oranini Giriniz :\n",yil+1);
		scanf("%d",&YagisOrani);
		if(YagisOrani<50)
		{
			AgacBoyu = AgacBoyu * 1.15f;	
		}
		else 
		{
			AgacBoyu = AgacBoyu * 1.25f;	
		}
		printf("%d.Yil Agac Boyu :%.2f\n",(yil+1),AgacBoyu);
		yil++;
	}while(yil<20);
	
}

*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*9- 10 elemanli bir dizi tanimlayarak, eleman degerini klavyeden giriniz. Dizi elemanlarini
once bastan sona, sonra sondan basa dogru alt alta ekran yazdiriniz ve ortalamasini hesaplayiniz. */

/*
#include <stdio.h>

main()
{
	int dizi[10],i,sayi;
	float ortalama=0;
	
	for(i=0;i<10;i++)
	{
		printf("%d.Dizi Elemanini Girin : \n",i+1);
		scanf("%d",&sayi);
		dizi[i]=sayi;
		ortalama = ortalama + sayi;
	}
	
	ortalama = ortalama/10;
	
	for(i=0;i<10;i++)
	{
		printf("\n%d",dizi[i]);
	}
		printf("\n ");
	for(i=10;i>0;i--)
	{
		printf("\n%d",dizi[i-1]);
	}
	
	printf("\n\nOrtalama: %.2f",ortalama);
	
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*10-Programin ciktisi

-----------------------
	n=1 Durumunda
	
	Sayi :1
	1.00
-----------------------
	n=5 Durumunda
	Sayi :1
	Sayi :2
	Sayi :4
	Sayi :5
	12.00

*/

//Saglama icin ilgili kod
#include <stdio.h>
main()
{
 float s=0;
 int i,n;
 printf("Deger..: \n");
 scanf("%d",&n);
 	for (i=1;i<=n;i++)
 	{
 	if (i%3 == 0) continue;
 	printf("\nSayi :%d",i);
 	s=s+i;
 	}
	printf(" \n%.2f ",s);
}



