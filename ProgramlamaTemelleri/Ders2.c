
/*
#include <stdio.h>
main()
{
	int sayi;
	printf("Bir Sayi Giriniz: ");
	scanf("%d",&sayi);
	if(sayi>100)
	{
		printf("Sayi 100 den Buyuktur");		
	}
	else
	{
		printf("Sayi 100 den Kucuktur");
	}
	else
	{
		printf("Sayi 100 e esit");
	}
}
*/

//-----------------------------------------------------------------------------------


/* Klavyeden vize ve final notu girilecek. Vizenin %40'i ve Finalin %60'ý alýnarak
ortalama hesaplanacak. Ortalama 60 ve uzeri ise ekrana ortalama ile birlikte Geçtiniz,
deðilse ekrana ortlama ile birlikte Butunlemeye Kaldýnýz yazacak programý yazýnýz. 
Butunleme notu girilecek ve butunleme notuna göre yeni ortalama hesaplanacak 
yeni ortlamaya göre gectiniz yazacak */

/*
#include <stdio.h>

main()
{
	int vize,final,ort,but;
	printf("Vize Notunu giriniz :");
	scanf("%d",&vize);
	printf("Final Notunu giriniz :");
	scanf("%d",&final);
	ort=(vize*0.4)+(final*60/100);
	if(ort>=60)
	{		
		printf("Notunuz : %d - Gectiniz",ort);	
	}		
	else	
	{
			printf("Notunuz : %d - Butunlemeye Kaldiniz",ort);				
			printf("\nButunleme Notunu Giriniz :");
			scanf("%d",&but);
			ort= (vize*0.4)+(but*60/100);
			
			if(ort>=60)
			{
				printf("Notunuz : %d - Butunleme ile Gectiniz - Notunuz : %d",ort);	
			}
			else 
			{
				printf("Notunuz : %d - Kaldiniz",ort);				
			}
	}
}

*/

//-----------------------------------------------------------------------------------

/* Klavyeden vize ve final notu girilecek. Vizenin 40 finalin 60'ý alýnarak
ortalma hesaplanacak. Ortalamaya göre harf notlarýný ekrana yazdýracak programý yazýnýn
0-40 FF 41-44 DD 45-49 DC 	50-54 CC	55-59 CB	60-69 BB	70-79 BA 	80-100 AA
*/

/*
#include <stdio.h>

main()
{
	int vize,final,ort,but;
	printf("Vize Notunu giriniz :");
	scanf("%d",&vize);
	printf("Final Notunu giriniz :");
	scanf("%d",&final);
	ort=(vize*0.4)+(final*60/100);
	if(ort>=0 && ort<=40)
	{		
		printf("Ortalamaniz : %d - Harf Notunuz : FF",ort);	
	}		
	else if	(ort<=44)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : DD",ort);	
	}
	else if	(ort<=49)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : DC",ort);	
	}
	else if	(ort<=54)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : CC",ort);	
	}
	else if	(ort<=59)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : CB",ort);	
	}
	else if	(ort<=69)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : BB",ort);	
	}
	else if	(ort<=79)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : BA",ort);	
	}
	else if	(ort<=100)
	{
		printf("Ortalamaniz : %d - Harf Notunuz : AA",ort);	
	}
	else
	{
			printf("Hatali Not Girdiniz");	
	}
}
*/

//-----------------------------------------------------------------------------------

/*
Klavyeden girilecek iki sayýyý, Klvayeden girilecek seçime göre iþleme tabi tutan programý yazýnýz
1-Toplama
2-Cikarma
3-Carpma
4-Bolme

Lutfen Bir Islem Seciniz : 3
Birinci Sayiyi Gir : 50
Ikinci Sayiyi Gir : 40
50*40 = 2000
*/

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
	
	if(secim == 1)
	{
		sonuc=sayi1+sayi2;	
		printf("%f + %f = %f",sayi1,sayi2,sonuc);
	}
	else if(secim == 2)
	{
		sonuc = sayi1 - sayi2;
		printf("%.0f - %.0f = %.0f",sayi1,sayi2,sonuc);
	}
	else if(secim == 3)
	{
		sonuc = sayi1 * sayi2;
		printf("%.0f * %.0f = %.0f",sayi1,sayi2,sonuc);
	}
	else if(secim == 4)
	{
		sonuc = sayi1 / sayi2;
		printf("%.0f / %.0f = %.2f",sayi1,sayi2,sonuc);
	}
	else 
	{
		printf("Hatali Islem Secimi");
	}
}







