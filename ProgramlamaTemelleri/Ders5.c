/*Klavyeden girilen 10 adet sayidan en buyuk ve en kucuk olanlaribulan ve ekrana
yazdiran program (Sadece 1 tane klavyeden sayi giris satiri olacak)*/

/*
#include <stdio.h>
main()
{
	int sayi,enb,enk,i;
	for(i=1;i<=10;i++)
	{
		printf("%d.Sayiyi giriniz :",i)	;
		scanf("%d",&sayi);
		if(i==1)
		{
			enb=sayi;
			enk=sayi;
		}
		if(sayi>enb) enb=sayi;				
		if(sayi<enk) enk=sayi;
	}
	
	printf("\nEn buyuk sayi : %d",enb);
	printf("\nEn kucuk sayi : %d",enk);
	
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////

/*Klavyeden girilen bir sayinin Asal olup olmadigini bulan,
eger asal degilse ilk hangi sayiya bolundugunu bulan program */

//Asal Sayi > 1 ve kendisi disindaki hicbir sayiya bolunmeyen sayilar

/*
#include <stdio.h>
main()
{
	int i,sayi,asalmi=0;
	
	printf("Sayi Giriniz :");
	scanf("%d",&sayi);
	if(sayi!=2)
	{
		for(i=2;i<=sayi-1;i++)
		{
			if(sayi%i==0)
			{
				asalmi=1;
				break;
			}
		}
	}
	
	if(asalmi==0)
	{
		printf("ASALDIR");
	}
	else 
	{
		printf("ASAL DEGILDIR %d'ye bolunur",i);
	}
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////

/*Klavyeden girilen cumledeki kelime sayisini bulan program..*/
/*
#include <stdio.h>
main()
{
		char kar;
		int bos=0;
		printf("Cumle Giriniz : ");
		do
		{
			scanf("%c",&kar);
			if(kar==' ')
			{
				bos++;
			}
		}
		while(kar!='\n');
		printf("Kelime Sayisi : %d",bos+1);
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////

/*Devam edilmek istendigi surece devam eden program*/

/*
#include <stdio.h>

main()
{
	int sayi1,sayi2;
	char devammi;
	do 
	{
		printf("1.Sayiyi Giriniz :");
		scanf("%d",&sayi1);
		printf("2.Sayiyi Giriniz :");
		scanf("%d",&sayi2);
		printf("%d + %d = %d",sayi1,sayi2,sayi1+sayi2);
		printf("\n\n Devam Etmek Ister misiniz [E/H/] : ");			
		do
		{
			scanf("%c",&devammi);	
		}
		while(devammi=='\n');		
	}
	while(devammi=='E' || devammi=='e');
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////

/*0 ile 100 arasında surekli rastgele sayi ureten programin girilen sayiyi kacinci seferde buldugunu bulan program*/

/*
#include <stdio.h>

main()
{
	/*
	int i,x;
	
	for(i=1;i<=5;i++)
	{
		x=rand()%101; //0 ile 100 arasinda
		//x=rand()%41 + 10; //10 ile 50 arasinda
		printf("\n%d",x);
	}
	*/
	
	
	/*
	char devammi;
	do 
	{
		int rasgelesayi, denemesayisi=0,sayi,i;
		printf("Sayi Gir :");
		scanf("%d",&sayi);
		while(1)
		{
			rasgelesayi=rand()%101;
			denemesayisi++;
			if(rasgelesayi==sayi)break;
		}
		printf("Toplam deneme sayisi : %d",denemesayisi);
		printf("\n\n Devam Etmek Ister misiniz [E/H/] : ");	
		
		do
		{
			scanf("%c",&devammi);	
		}
		while(devammi=='\n');		
	}
	while(devammi=='E' || devammi=='e');
	
	
	
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////

/*5 defa tura gelene dek gelen her atista ne geldigini ve toplam kac atis yapildigini yazan program*/


#include <stdio.h>

main()
{
	
	
	
	char devammi;
	do 
	{
	
		int para,turasayisi=0,atissayisi=0;
		while(1)
		{
			para=rand()%2; //0 veya 1 uretir
			atissayisi++;
			if(para==1) // 1i tura olarak kabul ettik
			{
				turasayisi++;
				printf("\nTURA");
			}
			else 
			{
				printf("\nYAZI");
			}
			if(turasayisi==5) break;
		}
		printf("\n%d.seferde 5 kez Tura Geldi",atissayisi);
		
		
		printf("\n\n Devam Etmek Ister misiniz [E/H/] : ");			
		do
		{
			scanf("%c",&devammi);	
		}
		while(devammi=='\n');		
	}
	while(devammi=='E' || devammi=='e');
		
	
}

























