#include <iostream>
using namespace std;

int main()
{
	setlocale(LC_ALL,"Turkish");
	
	int boyut,tektop=0,cifttop=0;	
	cout<<"Dizinin boyutunu girin: ";
	cin>>boyut;
	int dizi[boyut];
	cout<<"Lütfen "<<boyut<<" adet tamsayi giriniz..."<<endl;
	for(int i=0;i<boyut;i++)
	{
		cout<<"Eleman "<<i+1<<": ";
		cin>>dizi[i];
		if(dizi[i]%2==0)
		{
			cifttop+=dizi[i];	
		}
		else 
		{
			tektop+=dizi[i];
		}
	}
	cout<<"Tek sayilarin toplami: "<<tektop<<endl;
	cout<<"Cift sayilarin toplami: "<<cifttop<<endl;
	
	return 0;
}
