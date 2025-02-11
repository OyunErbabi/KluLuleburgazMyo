/*
Ekrana aþaðýdaki gibi bir çarpým tablosu yazdýran programý yazýnýz:
(Tablosu 1'den 10'a kadar olan sayýlar için olmalýdýr.)

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
Klavyeden girilen bir ay numarasýna göre (1-12), o aya ait mevsimi ekrana yazdýran bir program yazýnýz.

Ay numarasýný giriniz: 5  
Çýkýþ: Ýlkbahar.  

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

 If Barýndýran Döngü Sorusu
 
 Klavyeden girilen bir pozitif tam sayýya kadar olan tüm sayýlarýn karelerini hesaplayarak ekrana yazdýran bir program yazýnýz.
 
 Sayý giriniz: 5  
Çýkýþ:  
1'in karesi: 1  
2'nin karesi: 4  
3'ün karesi: 9  
4'ün karesi: 16  
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

Klavyeden girilen bir pozitif tam sayýnýn tam bölenlerini ekrana yazdýran bir program yazýnýz.

Bir sayý giriniz: 12  
Çýkýþ:  
Tam bölenler: 1, 2, 3, 4, 6, 12  

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

Klavyeden girilen bir pozitif tam sayý için, sayýnýn rakamlarýnýn toplamýný hesaplayan bir program yazýnýz.
Bir sayý giriniz: 12345  
Çýkýþ: Rakamlarýn toplamý: 15  

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

Kullanýcýdan sürekli sayý girmesini isteyen bir program yazýnýz. Kullanýcý 0 girdiðinde program sonlanmalý ve girilen sayýlarýn toplamýný ekrana yazdýrmalýdýr.

Bir sayý giriniz: 5  
Bir sayý giriniz: 10  
Bir sayý giriniz: -3  
Bir sayý giriniz: 0  
Çýkýþ: Girilen sayýlarýn toplamý: 12  
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
Bir kullanýcýdan bir sayý alýn. Bu sayýnýn pozitif olup olmadýðýný kontrol edin. Eðer sayý pozitif deðilse,
kullanýcýya tekrar sayý girmesini söyleyin. Kullanýcý pozitif bir sayý girdiðinde, bu sayýnýn karekökünü ekrana yazdýran bir program yazýnýz.

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





