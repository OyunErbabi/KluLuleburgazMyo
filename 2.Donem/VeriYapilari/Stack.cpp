#include <iostream>
using namespace std;

#define SIZE 10


struct stack{
	int data[SIZE];
	int top=-1;//en ust	
};

stack stk;

void push(int key) //eleman ekleme
{
	if(stk.top==SIZE-1)
	{
		cout<<"Stack doludur eleman eklenemez"<<endl;
	}
	else 
	{
		stk.top++;
		stk.data[stk.top]=key;
		cout<<"Stak'e veri gisiri yapildi"<<endl;
	}
}

void pop() //Eleman Cikartma
{
	if(stk.top==-1){
		cout<<"Stack bostur"<<endl;
	}
	else {
		cout<<stk.data[stk.top]<<" degeri stackten cikartildi"<<endl;
		stk.top--;
	}
}

void reset(){
	stk.top=-1;
	cout<<"Stack temizlendi"<<endl;
}

void print()
{
	system("cls");
	if(stk.top==-1){
		cout<<"Stack Bos Yazdirilacak Veri Yok"<<endl;
	}
	else 
	{
		for(int i=stk.top;i>-1;i--)
		{
			cout<<stk.data[i]<<endl;
		}
	}

}

int main(){
	setlocale(LC_ALL,"Turkish");
	int sayi,secim;
	while(1)
	{
		cout<<"1- Push"<<endl;
		cout<<"2- Pop"<<endl;
		cout<<"3- Reset"<<endl;
		cout<<"4- Print"<<endl;
		cout<<"5- Exit"<<endl;
		cout<<"Secim: "<<endl;
		cin>>secim;
		switch (secim)
		{
			case 1:
				cout<<"Sayi :";
				cin>>sayi;
				push(sayi);
				break;
			case 2:
				pop();
				break;
			case 3:
				reset();
				break;
			case 4:
				print();
				break;
			case 5:
				return 0;

		}
	}
}
