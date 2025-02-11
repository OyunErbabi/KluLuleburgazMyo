#include <iostream>
using namespace std;


int faktoriyel(int sayi)
{
	if(sayi<0)
	{
		return 0;	
	}
	else if(sayi==0 || sayi==1)
	{
		return 1;
	}
	else
	{
		return sayi*faktoriyel(sayi-1);
	}	
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int n;
	cout<<"Sayi : ";
	cin>>n;
	cout<<n<<"!= "<<faktoriyel(n)<<endl;
	return 0;
}
