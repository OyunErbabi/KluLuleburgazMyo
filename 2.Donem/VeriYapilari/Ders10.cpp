#include <iostream>
using namespace std;

#define SIZE 10

struct queue{
	int data[SIZE];
	int cnt; //Eleman sayisi
	int front; //Kuyruk Onu
	int rear;//Kuyruk Sonu
};

void initialize(queue *q){
	q->cnt=0;
	q->front=0;
	q->rear=-1;
}

bool isFull(queue *q){
	return (q->cnt==SIZE);
}

bool isEmpty(queue *q){
	return(q->cnt==0);
}

void enqueue(queue * q, int key){
	if(isFull(q))
	{
		cout<<"Kuyruk Dolmuþtur."<<endl;
	}
	else
	{
		q->rear++;
		
		if(q->rear==SIZE)
		{
			q->rear=0;
		}
		
		q->data[q->rear]=key;
		cout<<"Kuyruga eleman eklendi."<<endl;
		q->cnt++;
	}
}

void dequeue(queue *q)
{
	if(isEmpty(q))
	{
		cout<<"Kuyruk Bos Cikarilacak Eleman Yok"<<endl;
	}	
	else 
	{	
		if(q->front==SIZE){
			q->front=0;
		}	
	}
	cout<<q->data[q->front]<<" Kuyruktan cikartýldý"<<endl;
	q->front++;
	q->cnt--;
}

void print(queue * q){
	system("cls");
	
	if(isEmpty(q)){
		cout<<"Liste Bos Yazdirilacak Eleman Yok"<<endl;
	}
	else {
		cout<<"**VERILER**"<<endl<<endl;
		
		for(int i=q->rear; i>=q->front;i--)
		{
			cout<<q->data[i]<<endl;
		}
	}
}

int main(){
	setlocale(LC_ALL,"Turkish");
	queue qu;
	initialize(&qu);
	int sayi, secim;	
	
	while(1)
	{
		cout<<"**MENU**"<<endl;
		cout<<"1- Enqueue (Ekleme)"<<endl;
		cout<<"2- Dequeue (Cýkartma)"<<endl;
		cout<<"3- Yazdýr"<<endl;
		cout<<"4- Cýkýs"<<endl;
		cout<<"Secim :";
		cin>>secim;
		switch(secim)
		{
			case 1:
				cout<<"Sayi: ";
				cin>>sayi;
				enqueue(&qu, sayi);
			break;
			case 2:
				dequeue(&qu);
			break;
			case 3:
				print(&qu);
			break;
			case 4:
				//Cikiliyor
				return 0;
		}
	}
}


















