/*
#include <iostream>
using namespace std;

bool kontrol(int dizi1[],int dizi2[], int boyut)
{
	for(int i=0;i<boyut; i++)
	{
		if(dizi1[i]!=dizi2[i]){
			return false;
		}
	}
	return true;		
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int boyut=5;
	int dizi1[boyut];
	int dizi2[boyut];
	
	cout<<"Dizi-1 ELEMANLARININ ALINMASI"<<endl;
	for(int i=0; i<boyut;i++)
	{
		cout<<"Sayý-"<<i+1<<": ";
		cin>>dizi1[i];
	}
	
	cout<<"Dizi-2 ELEMANLARININ ALINMASI"<<endl;
	for(int i
	=0;i<boyut;i++)
	{
		cout<<"Sayý-"<<i+1<<": ";
		cin>>dizi2[i];
	}
	
	if(kontrol(dizi1,dizi2,boyut))
	{
		cout<<"diziler eþit..";
	}
	else 
	{
		cout<<"diziler eþit deðil..";
	}
}
*/

/* //Girilen diziyi ters cevirme
#include <iostream>
using namespace std;

void terscevir(int dizi[],int boyut)
{
	for(int i=0;i<boyut/2;i++)
	{
		int gecici = dizi[i];
		dizi[i]= dizi[boyut-i-1];
		dizi[boyut-i-1] = gecici;
	}
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int boyut;
	cout<<"Boyut :";
	cin>>boyut;
	int dizi[boyut];
	
	for(int i=0; i<boyut;i++)
	{
		cout<<"Sayý-"<<i+1<<": ";
		cin>>dizi[i];
	}
	
	terscevir(dizi,boyut);
	
	for(int i=0; i<boyut;i++)
	{
		cout<<dizi[i]<<" ";		
	}
	
}

*/

/*
#include <iostream>
using namespace std;

int kontrol(int dizi[],int boyut,int aranan)
{
	int sayac=0;
	for(int i=0; i<boyut;i++)
	{
		if(dizi[i]==aranan)
		{
			sayac++;
		}
	}
	return sayac;
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int boyut,aranan;
	cout<<"Boyut :";
	cin>>boyut;
	int dizi[boyut];
	
	for(int i=0; i<boyut;i++)
	{
		cout<<"Sayý-"<<i+1<<": ";
		cin>>dizi[i];
	}
	
	cout<<"Aradiginiz Sayi :";
	cin>>aranan;
	cout<<"Girdiðiniz Sayi :"<<aranan<<endl;	
	cout<<"Aradiginiz eleman dizi icinde "<<kontrol(dizi,boyut,aranan)<<" kere geçmiþtir";
	return 0;
}

*/


/*
#include <iostream>
using namespace std;

void topla(int dizi1[],int dizi2[], int boyut, int yenidizi[])
{
	for(int i=0; i<boyut;i++)
	{
		yenidizi[i]= dizi1[i]+dizi2[i];		
	}
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int boyut=5;
	int dizi1[boyut]{1,2,3,4,5};
	int dizi2[boyut]{6,7,8,9,10};
	int dizi3[boyut];
	topla(dizi1,dizi2,boyut,dizi3);
	cout<<"Yeni dizinin elemanlarý :";
	
	for(int i=0; i<boyut;i++)
	{
		cout<<dizi3[i]<<" ";
	}
	
	return 0;
}

*/

#include <iostream>
#include <algorithm>
using namespace std;

double ortancabul(int dizi[],int boyut)
{
	sort(dizi,dizi+boyut);
	if(boyut%2 !=0) //Dizinin boyutu tek ise 
	{
		return dizi[boyut/2];
	}
	else 
	{
		//return dizi[(boyut/2)] + dizi[(boyut/2)+1];
		
		int ortindis1 = (boyut/2)-1;
		int ortindis2 = boyut/2;
		return (dizi[ortindis1]+dizi[ortindis2])/2.0;
	}
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	cout<<"Boyut Giriniz: ";
	int boyut;
	cin>>boyut;
	int dizi[boyut];
	for(int i=0; i<boyut;i++)
	{
		cout<<"Sayý-"<<i+1<<": ";
		cin>>dizi[i];
	}
	
	cout<<"Ortanca Deger :"<<ortancabul(dizi,boyut)<<endl;
	return 0;
}
























