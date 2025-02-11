/* Klavyeden girilen üç ader x.y ve z sayýlarýnýn en küçüðünü bulan ve ekran yazdýran programý
if komut yapýsýný kullanarak yazýnýz.  || veya && öperatörü kullanmayýnýz */

/*
#include <stdio.h>
main()
{
	int x,y,z,enk;
	printf("X Sayisini Giriniz :");
	scanf("%d",&x);
	printf("Y Sayisini Giriniz :");
	scanf("%d",&y);
	printf("Z Sayisini Giriniz :");
	scanf("%d",&z);	
	
	if(x<y)
	{
		if(x<z)
		{
			printf("En Kucuk Sayý X tir");
		}
		else
		{
			printf("En Kucuk Sayý Z tir");
		}
	}		
	else 
	{
		if(x<y)
		{
			printf("En Kucuk Sayý Y tir");
		}
		else
		{
			printf("En Kucuk Sayý X tir");
		}
	}
	
	if(x<y)
	{
		enk=x;
	}	
	else 
	{
		enk=y;
	}
	
	if(z<enk)
	{
		enk=z;
	}
	printf("En Kucuk sayi : %d",enk);
}
*/
///////////////////////////////////////////////////////////////////////////////////////////
/*1'den klavyeden girilen bir deðere kadar olan tüm sayýlardan 3 katýnýn 4 fazlasý 5'e tam olarak bölünebilen
sayýlarý ekrana yazdýran program*/
/*
#include <stdio.h>
main()
{
	int sayi, i, adet=0;
	printf("Lutfen bir Sayi Giriniz :");
	scanf("%d",&sayi);
	
	//1 yöntem
	i=1;
	while(i<sayi)
	{
		if(()(i*3)+4)%5==0)	
		{
			printf("\nSayi :%d",i);
			adet++
		}
		i++;	
	}
	
	
	//2 yöntem
	for(i=1,i<=sayi,i++)
	{	
		if(()(i*3)+4)%5==0)	
		{
			printf("\nSayi :%d",i);
			adet++
		}
	}
	printf("\nAdet =%d",adet);
}
*/
///////////////////////////////////////////////////////////////////////////////////////////
/*Klaveyeden girilen iki deðer arasýndaki tek sayýlar ile çift sayýlarýn adetlerini ve toplamlarýný ayrý ayrý hesaplayarak ekrana yazdýran program*/
/*
#include <stdio.h>
main()
{
	int sayi1,sayi2,kucuk,buyuk,i;
	int tekadet=0,tektop=0,ciftadet=0,cifttop=0;
	
	printf("Sayi 1'i giriniz:");
	scanf("%d",&sayi1);
	
	printf("Sayi 2'i giriniz:");
	scanf("%d",&sayi2);
	
	if(sayi1<sayi2)
	{
		kucuk = sayi1;
		buyuk = sayi2;	
	}
	else if(sayi2>sayi1) 
	{
		kucuk =	sayi2;
		buyuk = sayi1;
	}
	else 
	{
		printf("\nAyni Sayilari Girdiniz!");
	}
	
	for(i = kucuk;i<=buyuk;i++)
	{
		if(i%2==0)
		{
			ciftadet++;
			cifttop = cifttop+i;
		}
		else if(i%2==1)
		{
				tekadet++;
				tektop = tektop+i;
		}
	}
	
	printf("\nCiftlerin Toplami: %d",cifttop);
	printf("\nCiftlerin Adeti: %d",ciftadet);
	printf("\nTeklerin Toplami: %d",tektop);
	printf("\nTeklerin Adeti: %d",tekadet);
	
	
}
*/
///////////////////////////////////////////////////////////////////////////////////////////
/*Klavyeden girilen pozitif tam sayý 10'dan büyük ise ekrana "Cok büyük sayi ugrastirma beni" yazan
6 ile 10 arasýnda ise küpünü hesaplayan, 5 ve 5 ten küçük ise faktoriyelini hesaplayan program*/
/*
#include <stdio.h>
#include <math.h>
main()
{
	int sayi,kup,fact=1,i;
	printf("Bir Sayi giriniz :");
	scanf("%d",&sayi);
	
	if(sayi<=0)
	{
		printf("Lutfen Pozitif Bir Sayi Giriniz!!!");
	}
	else if(sayi>10)
	{
		printf("Cok Buyuk Sayi Ugrastirma Beni");
	}
	else if(sayi>=6)
	{
		kup = pow(sayi,3); // 1.paramete taban, 2.parametre üssü yani sayi^3
		printf("%d Sayisinin Kupu : %d",sayi,kup);
	}
	else 
	{
		i=1;
		while(i<=sayi)
		{
			fact=fact*i;
			i++;	
		}
		
		printf("%d! = %d",sayi,fact);
	}
}
*/
///////////////////////////////////////////////////////////////////////////////////////////
/*Klavyeden 0 sýfýr girilene dek girilen tüm sayýlarýn, 
pozitif olanlarýn adetini ve toplamýný,
negatif olanlarýn adetini ve toplamýný,
hesaplayarak ekrana yazdýrýlan program.*/
/*
#include <stdio.h>
main()
{
	int negtop=0,negadet=0,poztop=0,pozadet=0,sayi;
	
	while(1)
	{
		printf("\nSayi Giriniz :");
		scanf("%d",&sayi);		
		if(sayi==0) //if(sayi==0) break;
		{
			break;
		}
		
		if(sayi>0)
		{
			poztop=poztop+sayi; //poztop += sayi;
			pozadet++;
		}
		else 
		{
			negtop=negtop+sayi; //negtop += sayi;
			negadet++;
		}		
	}
	
	printf("\nPozitif Adet :%d",pozadet);
	printf("\nPozitif Toplam :%d",poztop);
	printf("\nNegatitif Adet :%d",negadet);
	printf("\nNegatitif Toplam :%d",negtop);
}
*/

///////////////////////////////////////////////////////////////////////////////////////////
/*Klavyeden girilen bir sayýyý tersten yazdýran ve sayinin kaç basamakli oldugunu bulan program*/

#include <stdio.h>
main()
{
	int basamakadet=0,sayi,basamakdegeri;
	printf("Sayi Giriniz : ");
	scanf("%d",&sayi);
	
	printf("Sayinin Tersi :");
	
	while(sayi>=10) //while(sayi>9)
	{
			basamakdegeri = sayi%10;
			printf("%d",basamakdegeri);
			sayi= sayi/10;
			basamakadet++;
			
	}
	
	printf("%d",sayi);
	printf("\nBasamak Sayisi : %d",basamakadet+1);
	
}













