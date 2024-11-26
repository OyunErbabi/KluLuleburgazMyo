/*Klavyeden kenar uzunluklari girilen bir dikdortgenin
alan ve cevresini hesapyalarak ekrana yazdiran
 programi yaziniz
*/

#include <stdio.h>
#include <locale.h>
main()
{
	setlocale(LC_ALL, "Turkish");
	int x,y,alan,cevre;
	printf("1. Kenar Uzunlugunu Giriniz :");
	scanf("%d",&x);
	printf("2. Kenar Uzunlugunu Giriniz :");
	scanf("%d",&y);
	alan=x*y;
	cevre=2*(x+y);
	printf("Cevre = %d\nAlan = %d",cevre,alan);
}
