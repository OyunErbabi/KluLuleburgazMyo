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

//-----------------------------------------------------------------------------
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

