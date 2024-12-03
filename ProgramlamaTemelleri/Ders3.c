/*
#include <stdio.h>
main ()
{
	char kr;
	printf("Bir karakter Giriniz : ");
	scanf("%c",&kr);
	
	switch(kr)
	{
		case 'a': printf("\aa harfine bastiniz");
		break;
		case 'b': printf("\ab harfine bastiniz");
		break;
		case 'c': printf("\ab harfine bastiniz");
		break;
		default: printf("\aa-b-c disinda bir harfine bastiniz");
	}
	
}
*/
//-----------------------------------------------------------------------------
//Geçen haftanýn konusu switch blogu ile yazmak
/*
#include <stdio.h>
main()
{	
	int secim;
	float sayi1,sayi2,sonuc;	
	printf("1-Toplama\n2-Cikarma\n3-Carpma\n4-Bolme\nLutfen Bir islem Seciniz[1-2-3-4]:\n");
	scanf("%d",&secim);
	printf("1. Sayiyi Giriniz :");
	scanf("%f",&sayi1);
	printf("2. Sayiyi Giriniz :");
	scanf("%f",&sayi2);	
	
	switch(secim)
	{
		case 1:
			sonuc=sayi1+sayi2;	
			printf("%f + %f = %f",sayi1,sayi2,sonuc);
			break;
		case 2:
			sonuc = sayi1 - sayi2;
			printf("%.0f - %.0f = %.0f",sayi1,sayi2,sonuc);
			break;
		case 3:
			sonuc = sayi1 * sayi2;
			printf("%.0f * %.0f = %.0f",sayi1,sayi2,sonuc);
			break;
		case 4:
			sonuc = sayi1 / sayi2;
			printf("%.0f / %.0f = %.2f",sayi1,sayi2,sonuc);			
			break;
		default:
			printf("Hatali Islem Secimi");
			break;
	}
	
}
*/
//-----------------------------------------------------------------------------
/*Klavyeden A veya B harfine basýlarak kare yada daire secimi yapilacak,
yapýlan secime gore kenar uzunlugu yada yaricap bilgisi girilecek,
1 veya 2 ye basilarak cevre yada alan secimi yapilacaki yapilan secimlere gore
ilgili seklin ilgili hesabi yapilarak ekrana yazdirilacak. */

/*
#include <stdio.h>

main()
{
	char secim;
	int islem;
	float uzunluk,pi=3.14,sonuc;
	
	printf("A-Kare\nB-Daire\nLutfen Islem Yapilacak Sekli Seciniz [A/B] -> ");
	scanf("%c",&secim);
	
	switch(secim)
	{
		case 'A':
			printf("Karenin kenar uzunlugunu giriniz :");
			scanf("%f",&uzunluk);
			printf("1-Cevre\n2-Alan\nGerceklestirmek istediginiz islemi seciniz :");
			scanf("%d",&islem);			
			switch(islem)
			{
				case 1:
					sonuc = 4*uzunluk;
					printf("Karenin Cevresi = %.0f",sonuc);
					break;
				case 2:
					sonuc = uzunluk*uzunluk;
					printf("Karenin alani = %.0f",sonuc);
					break;	
			}
			break;
		case 'B':
			printf("Dairenin yaricap uzunlugunu giriniz :");
			scanf("%f",&uzunluk);
			printf("1-Cevre\n2-Alan\nGerceklestirmek istediginiz islemi seciniz :");
			scanf("%d",&islem);			
			switch(islem)
			{
				case 1:
					sonuc = 2*pi*uzunluk;
					printf("Dairenin Cevresi = %.0f",sonuc);
					break;
				case 2:
					sonuc = uzunluk*uzunluk*pi;
					printf("Dairenin alani = %.0f",sonuc);
					break;	
			}
			break;
		default:
			printf("Yanlis secim yaptiniz!!!");
			break;
	}
	
	
}
*/

//-----------------------------------------------------------------------------
/*
#include <stdio.h>

main()
{
	int x,y;
	x=5;
	y=++x;
	printf("\nX in degeri : %d ",x);
	printf("\nY in degeri : %d ",y);
	
}
// Cýktý : 6-6
*/
//-----------------------------------------------------------------------------
/*
#include <stdio.h>

main()
{
	int x,y;
	x=5;
	y=x++;
	printf("\nX in degeri : %d ",x);
	printf("\nY in degeri : %d ",y);
	
}
// Cýktý : 6-5
*/
//-----------------------------------------------------------------------------
/*
#include <stdio.h>

main()
{
	int x,y;
	x=5;
	y=--x;
	printf("\nX in degeri : %d ",x);
	printf("\nY in degeri : %d ",y);
	
}
// Cýktý : 4-4
*/
//-----------------------------------------------------------------------------
/*
#include <stdio.h>

main()
{
	int x,y;
	x=5;
	y=x--;
	printf("\nX in degeri : %d ",x);
	printf("\nY in degeri : %d ",y);
	
}
// Cýktý : 4-5
*/
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

/*
//Yazým biçimi olarak if'e benzerlik uzerinden while dongusu
#include <stdio.h>

main ()
{
	int i = 1;
	while(i<=5)
	{
		printf("\n%d",i);
		i++;//i=i+1;
	}
}
*/

//-----------------------------------------------------------------------------

/*
#include <stdio.h>

main ()
{
	int sayac = 1;
	do
	{
		printf("\n%d",sayac);
		sayac++;//i=i+1;
	}
	while(sayac<=5);
	
}
*/
//-----------------------------------------------------------------------------
/*
//For Dongusu
#include <stdio.h>

main ()
{
	int i;
	for(i=1;i<=5;i++)
	{
		printf("\n%d",i);
	}
	
}
*/
//-----------------------------------------------------------------------------
/*
//Break ornek
#include <stdio.h>

main ()
{
	int i;
	for(i=1;i<=5;i++)
	{
		if(i==3) break;
		printf("\n%d",i);
	}
	
}
*/
//-----------------------------------------------------------------------------
/*
//Continue ornek
#include <stdio.h>

main ()
{
	int i;
	for(i=1;i<=5;i++)
	{
		if(i==3) continue;
		printf("\n%d",i);
	}
	
}
*/
//-----------------------------------------------------------------------------
//Klavyeden girilen sayýya kadar olan sayýlarýn toplamý. While döngüsü ile

/*
#include <stdio.h>
main ()
{
	int i,sayi,toplam=0;
	printf("Bir Sayi Giriniz :");
	scanf("%d",&sayi);
	
	i = 1;
	while(i<=sayi)
	{
		toplam = toplam +i;
		i++;		
	}
	printf("Sonuc : %d",toplam);
}
*/

//-----------------------------------------------------------------------------
/*
//Klavyeden girilen 10 Adet sayýnýn toplamý While döngüsü ile

#include <stdio.h>
main ()
{
	int i,sayi,toplam=0;
	i = 1;
	while(i<=10)
	{
		printf("%d.Sayiyi Giriniz :",i);
		scanf("%d",&sayi);
		toplam = toplam +sayi;
		i++;		
	}
	printf("Sonuc : %d",toplam);
}
*/
//-----------------------------------------------------------------------------

