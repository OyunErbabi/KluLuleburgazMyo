/*
Ekrana a�a��daki gibi bir �arp�m tablosu yazd�ran program� yaz�n�z:
(Tablosu 1'den 10'a kadar olan say�lar i�in olmal�d�r.)

1 x 1 = 1    1 x 2 = 2    1 x 3 = 3    ...    1 x 10 = 10
2 x 1 = 2    2 x 2 = 4    2 x 3 = 6    ...    2 x 10 = 20
...
10 x 1 = 10  10 x 2 = 20  10 x 3 = 30  ...    10 x 10 = 100

*/

/*
#include <stdio.h>

main()
{
	int i,j;
	
	for(i=1;i<=10;i++)
	{
		for(j=1;j<=10;j++)
		{
			printf("%d x %d = %d",i,j,i*j);
			printf("\t");
		}
		printf("\n");
	}
	
}
*/

//---------------------------------------------------------------------------

//Switch-Case Sorusu
/*
Klavyeden girilen bir ay numaras�na g�re (1-12), o aya ait mevsimi ekrana yazd�ran bir program yaz�n�z.

Ay numaras�n� giriniz: 5  
��k��: �lkbahar.  

*/

/*

#include <stdio.h>

main()
{
	int ay;
	printf("Ay numarasini girin [1-12] :");
	scanf("%d",&ay);
	printf("\n");
	switch(ay)
	{
		case 1:
			printf("Ocak");
		break;	
		case 2:
			printf("Subat");
		break;
		case 3:
			printf("Mart");
		break;
		case 4:
			printf("Nisan");
		break;
		case 5:
			printf("Mayis");
		break;
		case 6:
			printf("Haziran");
		break;
		case 7:
			printf("Temmuz");
		break;
		case 8:
			printf("Agustos");
		break;
		case 9:
			printf("Eylul");
		break;
		case 10:
			printf("Ekim");
		break;
		case 11:
			printf("Kasim");
		break;
		case 12:
			printf("Aralik");
		break;
	}
}
*/

//---------------------------------------------------------------------------

/*

 If Bar�nd�ran D�ng� Sorusu
 
 Klavyeden girilen bir pozitif tam say�ya kadar olan t�m say�lar�n karelerini hesaplayarak ekrana yazd�ran bir program yaz�n�z.
 
 Say� giriniz: 5  
��k��:  
1'in karesi: 1  
2'nin karesi: 4  
3'�n karesi: 9  
4'�n karesi: 16  
5'in karesi: 25  
*/
/*

#include <stdio.h>
#include <math.h>

main()
{
	int sayi,karesi,i;
	printf("Sayi Giriniz: ");
	scanf("%d",&sayi);
	
	for(i=1;i<=sayi;i++)
	{
		karesi = pow(i,2);
		
		printf("\n%d. karesi: %d",i,karesi);	
	}
}

*/

//---------------------------------------------------------------------------


/*

Klavyeden girilen bir pozitif tam say�n�n tam b�lenlerini ekrana yazd�ran bir program yaz�n�z.

Bir say� giriniz: 12  
��k��:  
Tam b�lenler: 1, 2, 3, 4, 6, 12  

*/

/*

#include <stdio.h>

main()
{
	int sayi,i;
	printf("Bir Sayi Giriniz :");
	scanf("%d",&sayi);
	
	printf("\nTam Bolenler:");
	
	for(i=1;i<=sayi;i++)
	{
		if(sayi%i==0)
		{
			printf(" %d",i);	
			
			if(i!=sayi)
			{
				printf(",");
			}
		}
	}
}

*/

//---------------------------------------------------------------------------

/*

Klavyeden girilen bir pozitif tam say� i�in, say�n�n rakamlar�n�n toplam�n� hesaplayan bir program yaz�n�z.
Bir say� giriniz: 12345  
��k��: Rakamlar�n toplam�: 15  

*/

/*
#include <stdio.h>

main()
{
	int sayi,birler;
	int toplam = 0;
	printf("Bir Sayi Giriniz: ");
	scanf("%d",&sayi);
	
	while(1)
	{
		if(sayi>10)	
		{		
			birler = sayi%10;
			sayi = sayi/10;
			toplam = toplam + birler;	
		}
		else 
		{
			toplam = toplam +sayi;	
			break;
		}
	}
	
	printf("Rakamlarin Toplami: %d",toplam);
	
}
*/

//---------------------------------------------------------------------------

/*

Kullan�c�dan s�rekli say� girmesini isteyen bir program yaz�n�z. Kullan�c� 0 girdi�inde program sonlanmal� ve girilen say�lar�n toplam�n� ekrana yazd�rmal�d�r.

Bir say� giriniz: 5  
Bir say� giriniz: 10  
Bir say� giriniz: -3  
Bir say� giriniz: 0  
��k��: Girilen say�lar�n toplam�: 12  
*/

/*
#include <stdio.h>

main()
{
	int sayi,toplam;
	
	while(1)
	{
		printf("Bir Sayi Giriniz: ");
		scanf("%d",&sayi);
		toplam = toplam + sayi;
		
		if(sayi == 0)
		{
			break;	
		}
	}
	
	printf("Girilen Sayilarin Toplami: %d",toplam);
}

*/

//---------------------------------------------------------------------------

/*
Bir kullan�c�dan bir say� al�n. Bu say�n�n pozitif olup olmad���n� kontrol edin. E�er say� pozitif de�ilse,
kullan�c�ya tekrar say� girmesini s�yleyin. Kullan�c� pozitif bir say� girdi�inde, bu say�n�n karek�k�n� ekrana yazd�ran bir program yaz�n�z.

*/

#include <stdio.h>
#include <math.h>

main()
{
	int sayi;
	double karekoku;	
	
	do
	{
		printf("Bir Sayi Girin: ");		
		scanf("%d",&sayi);
	}
	while (sayi<0);
	
	karekoku = sqrt(sayi);
	printf("%d'nin KareKoku: %.2f",sayi,karekoku);
	
}





