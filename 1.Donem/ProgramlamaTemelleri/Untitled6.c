//Carpim tablosunu yazan program 1*1 - 10*10'a kadar

/*

#include <stdio.h>

main()
{
	int i,j;
	
	for(i=1;i<=10;i++)
	{
		for(j=1;j<=10;j++)	
		{
			printf("%4d",(i*j));
		}
		printf("\n");
	}
	
}

*/

/*

#include <stdio.h>

main()
{
	int i,j;
	i=1;
	
	while(i<=10)
	{
		j=1;
		while(j<=10)
		{
			printf("%4d",(i*j));
			j++;
		}
		printf("\n");
		i++;
	}
	
}

*/




////////////////////////////////////////////////////////////////////////////////////
//Asagidaki sekili yazan program
/*			*
			*	*
			*	*	*
			*	*	*	*
			*	*	*	*	*
*/

/*
#include <stdio.h>

main()
{
	int i,j;
	for(i=1;i<=5;i++)
	{
		for(j=1;j<=i;j++)	
		{
			printf("* ");
		}
		printf("\n");
	}
}

*/

////////////////////////////////////////////////////////////////////////////////////
//Asagidaki sekili yazan program
/*
			*	*	*	*	*
			*	*	*	*	
			*	*	*
			*	*	
			*
*/

/*

#include <stdio.h>
main()
{
	int i,j;
	for(i=5;i>=1;i--)
	{
		for(j=1;j<=i;j++)	
		{
			printf("* ");
		}
		printf("\n");
	}
}

*/

////////////////////////////////////////////////////////////////////////////////////
/*
50 kisilik bir sinifta 7 farkli ders okutuluyor,
Ogrenci numarasý ve ogrencilerin her bir dersten aldigi not ortalamari klavyeden girilecek.
Her ogrencinin ogrenci numarasi ve dönem ortalamalarini ekrana yazan ve tum sinifin basari ortalmasi
ekrana yazan programi yaziniz. */

/*
#include <stdio.h>
main()
{
	int OgrenciSayisi=0,DersSayisi=0,OgrenciNo,DersNot,DersTop=0;
	float DersOrt,BasariTop=0,BasariOrt;
	
	for(OgrenciSayisi=1;OgrenciSayisi<=50;OgrenciSayisi++)
	{
		printf("\n%d. Ogrencinin Numarasini Giriniz :",OgrenciSayisi);
		scanf("%d",&OgrenciNo);
		
		for(DersSayisi=1;DersSayisi<=7;DersSayisi++)
		{
			printf("%d. Ders Notunu Giriniz :",DersSayisi);//
			scanf("%d",&DersNot);
			DersTop=DersTop+DersNot;
		}
		DersOrt=DersTop/7;
		printf("Ogrenci no: %d - Not Ortalamasi : %.2f",OgrenciNo,DersOrt);
		BasariTop=BasariTop+DersOrt;
	}
	BasariOrt=BasariTop/50;
	printf(\n"Sinif Basari Ortalmasi : %.2f",BasariOrt);
		
}

*/

////////////////////////////////////////////////////////////////////////////////////


//			Sinavda Cikmasi Muhtemel Konular
// 1 Adet Yildiz veya carpim tablosu(ic ice dongu) Sorusu
// 1 Adet Switch-case durumlu Soru
// 2 Adet dongu ifadeli (while,DoWhile) Sorular









