/*

#include <iostream>
using namespace std;

int ushesapla(int taban, int us)
{
	if(us==0)
	{
		return 1;		
	}	
	else if(us==1)
	{
		return taban;	
	}
	else
	{
		return taban*ushesapla(taban,us-1);
	}	
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int a,b;
	cout<<"Taban: ";
	cin>>a;
	cout<<"Us: ";
	cin>>b;
	cout<<"Sonuc :"<<ushesapla(a,b)<<endl;
	return 0;
}

*/


/*
/// Fibonacci sayisini hesaplayan program(Vize Sorusu)
#include <iostream>
using namespace std;

int fib(int sirano)
{
	if(sirano==0 || sirano==1)
	{
		return sirano;	
	}
	else 
	{
		return fib(sirano-1)+ fib(sirano-2);
	}
	
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int n;
	cout<<"Sirano: ";
	cin>>n;
	cout<<"Sonuc :"<<fib(n)<<endl;
	return 0;
}

*/


/*

////Tribonacci Serisi
#include <iostream>
using namespace std;

int tib(int sirano)
{
	if(sirano==0)
	{
		return sirano;	// return 0;
	}
	else if(sirano==1 || sirano == 2)
	{
		return 1;
	}
	else 
	{
		return tib(sirano-1) + tib(sirano-2) + tib(sirano-3);
	}
	
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int n;
	cout<<"Sirano: ";
	cin>>n;
	cout<<"Sonuc :"<<tib(n)<<endl;
	return 0;
}

*/

////Ebob ekok

#include <iostream>
using namespace std;

int ebob(int s1,int s2)
{
	if(s2==0)
	{
		return s1;	
	}	
	else 
	{
		return ebob(s2,s1%s2);
	}
}

int ekok(int s1,int s2)
{
	return (s1*s2)/ebob(s1,s2);
}

int main()
{
		setlocale(LC_ALL,"Turkish");
		int s1,s2;
		/*
		cout<<"Sayi 1: ";
		cin>>s1;
		cout<<"Sayi 2: ";
		cin>>s2;
		*/
		cout<<"Sirasiyla iki sayi giriniz :";
		cin>>s1>>s2;
		cout<<"Ebob :"<<ebob(s1,s2)<<endl;		
		cout<<"Ekok :"<<ekok(s1,s2)<<endl;				
		return 0;	
}
