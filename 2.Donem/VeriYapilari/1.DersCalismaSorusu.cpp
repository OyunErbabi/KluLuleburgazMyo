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
