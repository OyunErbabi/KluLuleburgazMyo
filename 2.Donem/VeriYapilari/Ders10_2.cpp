#include <iostream>

using namespace std;


struct node{
	int data;
	struct node*next;
};

struct queue{
	int cnt;
	struct node*front;
	struct node*rear;
};

void initialize(queue * q){
	q->cnt=0;
	q->front=NULL;
	q->rear=NULL;
}

bool isEmpty(queue *q){
	return (q->cnt==0);
}

void enqueue(queue * q, int key){
	struct node*newnode=new node();
	newnode->data=key;
	newnode->next=NULL;
	
	if(isEmpty(q))
	{
		q->front=newnode;
		q->rear=q->front;
		cout<<key<<" ilk eleman olarak eklendi."<<endl;
		q->cnt++;
	}
	else 
	{
		newnode->next=q->rear;
		q->rear=newnode;
		cout<<key<<" verisi kuyruga eklendi"<<endl;
		q->cnt++;
	}	
}

void dequeue(queue * q)
{
	if(isEmpty(q))
	{
		cout<<"Kuyruk bos, cikartilacak veri yok."<<endl;
	}
	else if(q->cnt==1)
	{
		cout<<q->front->data<<" verisi cikarildi. Kuyrukta eleman kalmadi."<<endl;
		delete q->front;
		q->front=NULL;
		q->rear=NULL;
		q->cnt--;
	}
	else 
	{
		cout<<q->front->data<<" verisi kuyruktan cikartildi."<<endl;
		struct node*temp=q->rear;
		while(temp->next != q->front)
		{
			temp=temp->next;
		}
		delete q->front;
		q->front=temp;
		q->front->next=NULL;
		q->cnt--;
	}
}

void print(queue * q)
{
	system("cls");
	if(isEmpty(q)){
		cout<<"Kuyruk bos yazdirilacak veri yok"<<endl;		
	}
	else 
	{
		struct node*temp=q->rear;
		while (temp!=NULL)
		{
			cout<<temp->data<<"-> ";
			temp=temp->next;
		}
	}
	
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	queue qu;
	initialize(&qu);
	int sayi,secim;
	while(1)
	{
		cout<<"*Menu*"<<endl<<endl;
		cout<<"1- Enqueue"<<endl;
		cout<<"2- Dequeue"<<endl;
		cout<<"3- Print"<<endl;
		cout<<"4- Cikis"<<endl;
		cout<<"Secim: ";
		cin>>secim;		
		switch(secim){
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
				cout<<"Kapatiyoruz.."<<endl;
				return 0;				
		}
	}
	
}



















