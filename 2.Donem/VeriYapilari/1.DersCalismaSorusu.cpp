/*
#include <iostream>
using namespace std;

int recursiveMultiply(int a, int b)
{
	if(b==0)
	{
	 	return 0;	
	}
	else if(b==1)
	{
		return a;	
	}
	else if (b>1)
	{
		//return a*(b-1)+a;
		return a+recursiveMultiply(a,b-1);
	}
}

int main()
{
	int a,b;
	cout<<"Sayi 1:"<<endl;
	cin>>a;
	cout<<"Sayi 2:"<<endl;
	cin>>b;
	cout<<"Sonuc : "<<recursiveMultiply(a,b);
	return 0;
}
*/

///////////////////////////////////////////////
/*
Ornek Soru

Soru:
Bir ciftlikte, her tavuk her gun x tane yumurta yumurtlamaktadir.
n gun boyunca toplam kac yumurta uretilecegini ozyinelemeli (recursive) bir fonksiyon kullanarak hesaplayan bir C++ programi yazin.

Kurallar:

-Ozyineleme (recursion) kullanmalisiniz.
-Carpma (*) islemi kullanilmamalidir.
-Sadece toplama (+) islemi kullanilmalidir.
*/

#include <iostream>
using namespace std;

int ToplamYumurta = 0;

int carpma(int a, int b) {
    if (b == 0) return 0;
    return a + carpma(a, b - 1);
}

int RecursiveDays(int tavuk,int yumurta,int gun)
{
	if(gun==0)
	{
		return 0;
	}
	else if(gun==1)
	{
		return tavuk * yumurta;	
	}
	else 
	{
		return carpma(tavuk,yumurta) + RecursiveDays(tavuk,yumurta,gun-1);
	}
}

int main()
{
	int t,y,g;
	cout<<"Tavuk Adeti:"<<endl;
	cin>>t;
	cout<<"Gunde Ne Kadar Yumurtluyor :"<<endl;
	cin>>y;
	cout<<"Kac Gun:"<<endl;
	cin>>g;
	cout<<"Toplam Yumurta Sayisi: "<<RecursiveDays(t,y,g);
	return 0;
}
