#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL,"Turkish");
	
	
	/*
	int dizi[5];
	for(int i=0;i<5;i++)
	{
		cout<<i+1<<". sayiyi giriniz :";
		cin>>dizi[i];
	}
	cout<<"Kayit tamamlandi."<<endl<<endl;
	for(int i=0;i<5;i++)
	{
	cout<<"Dizinin "<<i<<". indisindeki eleman: "<<dizi[i]<<endl;
	}
	returun 0;
	*/
	
	/*
	int dizi[6];
	for(int i=0;i<6;i++)
	{
		dizi[i]=0;
	}
	*/
	
	/*
	#define N 5
	int dizi1[N] ={1,2,3,4,5};
	int dizi2[N] ={1,2};
	for (int i = 0; i<N; i++)
	{
		cout<<"Dizi1["<<i<<"]="<<dizi1[i]<<"\t";
		cout<<"Dizi2["<<i<<"]="<<dizi2[i]<<endl;
	}
	
	return 0;
	*/
	
	/*
	int dizi[]={4,1,7,3,9,2};
	int boyut = sizeof(dizi)/sizeof(dizi[0]); //Dizinin Boyutunu verir
	int eb = dizi[0]; //eb=4
	for(int i=0;i<boyut;i++)
	{
	 	if(dizi[i]>eb)
		{
	 		eb = dizi[i];
		}	
	}
	cout<<"En Büyük Sayi : "<<eb<<endl;
	return 0;
	*/
	
	/*
	int dizi[]={4,1,7,3,9,2};
	int boyut = sizeof(dizi)/sizeof(dizi[0]); //Dizinin Boyutunu verir
	int ek = dizi[0]; //eb=4
	for(int i=0;i<boyut;i++)
	{
	 	if(dizi[i]<ek)
		{
	 		ek = dizi[i];
		}	
	}
	cout<<"En Küçük Sayi : "<<ek<<endl;
	return 0;
	*/
		
	int boyut;
	float toplam=0, ortalama;
	cout<<"Boyut: ";
	cin>>boyut;
	int dizi[boyut];
	cout<<"Lütfen "<<boyut<<" adet sayý giriniz.."<<endl;
	for(int i = 0; i<boyut;i++)
	{
		cout<<"Sayi-"<<i+1<<": ";
		cin>>dizi[i];
		toplam+=dizi[i];
	}
	ortalama = toplam/boyut;
	cout<<"Toplam: "<<toplam<<" Ortalama: "<<ortalama<<endl;
	return 0;
	
}
