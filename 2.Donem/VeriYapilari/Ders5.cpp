#include <iostream>
using namespace std;


/* 
//Cift Boyutlu Dizi olusturma
int main()
{
	setlocale(LC_ALL,"Turkish");
	int dizi[4][3];
	//Degerleri kullanicidan alma
	for(int i =0; i<4;i++)//Satirlari kontrol etmek icin
	{
		for(int j=0;j<3;j++)//Sutunlari kontrol etmek icin
		{
			cout<<"dizi["<<i<<"]["<<j<<"]: ";
			cin>>dizi[i][j];
		}
	}
	
	for(int i =0; i<4;i++)//Satirlari kontrol etmek icin
	{
		for(int j=0;j<3;j++)//Sutunlari kontrol etmek icin
		{
			cout<<"dizi["<<i<<"]["<<j<<"]: "<<dizi[i][j]<<endl;
			}
	}
	
	return 0;
}

*/


/*
//Satranc tablosu olusturma
int main()
{
	setlocale(LC_ALL,"Turkish");
	char satranc[8][8];
	
	for(int i =0; i<8;i++)
	{
		for(int j=0;j<8;j++)
		{
			if((i+j)%2==0)
			{
			 	satranc[i][j]='B';
			}
			else 
			{
				satranc[i][j] = 'S';
			}
		}
	}
	
	
	cout<<"Cikti"<<endl;
	for(int i =0; i<8;i++)
	{
		for(int j=0;j<8;j++)
		{
			cout<<satranc[i][j];
		}
		cout<<endl;
	}
	
	return 0;
}

*/

//Bagli liste olusturma
/*
struct node{
	int data;
	struct node*next;
};

int main()
{
	setlocale(LC_ALL,"Turkish");
	
	struct node*n1=new node();
	struct node*n2=new node();
	struct node*n3=new node();
	
	n1->data=10;
	n2->data=20;
	n3->data=30;
	
	n1->next=n2;
	n2->next=n3;
	n3->next=NULL;
	
	cout<<n1->data<<endl;
	cout<<n2->data<<endl;
	cout<<n3->data<<endl;
	
	return 0;
}

*/


//Gezinme Adimlari olusturma

struct node{
	int data;
	struct node*next;
};

int main()
{
	setlocale(LC_ALL,"Turkish");
	
	struct node*n1=new node();
	struct node*n2=new node();
	struct node*n3=new node();
	
	n1->data=10;
	n2->data=20;
	n3->data=30;
	
	n1->next=n2;
	n2->next=n3;
	n3->next=NULL;
	struct node*gecici=n1;
	
	while(gecici!=NULL)
	{
		cout<<gecici->data<<endl;	
		gecici=gecici->next;
	}
	
	return 0;
}







