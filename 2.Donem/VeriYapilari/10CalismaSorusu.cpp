#include <iostream>
using namespace std;

int siraNo = 1;

struct node
{
	int sira;
	string adi;
	struct node*next;
};

struct queue
{
	int cnt;
	struct node*front;
	struct node*rear;	
};


void initilize(queue * q)
{
	q->cnt=0;
	q->front=NULL;
	q->rear=NULL;
}

bool isEmpty(queue *q)
{
	return (q->cnt==0);
}

void enqueue(queue * q)
{
	struct node*newnode = new node();
	cout<<"Musteri Adi Giriniz: ";	
	cin>>newnode->adi;
	newnode->sira=siraNo;
	newnode->next=NULL;
	
	system("cls");

	if(isEmpty(q))
	{
		q->front=newnode;		
		cout<<newnode->adi<<" isimli musteri ilk siraya eklendi"<<endl;
	}
	else 
	{
		newnode->next=q->rear;		
		cout<<newnode->adi<<" isimli musteri "<<siraNo<<". siraya eklendi."<<endl;
	}

	q->rear=newnode;
	q->cnt++;
	siraNo++;
}

void dequeue (queue * q)
{
	if(isEmpty(q))
	{
		cout<<"Kuyruk bos silinecek musteri yok."<<endl;
		return;
	}

	system("cls");

	if(q->cnt==1)
	{
		cout<<q->front->sira<<"("<<q->front->adi<<") verisi silindi.. Kuyruk bos."<<endl;
		delete q->front;
		q->front=NULL;
		q->rear=NULL;		
	}
	else 
	{
		cout<<q->front->sira<<"("<<q->front->adi<<") verisi silindi.."<<endl;
		struct node*temp=q->rear;
		while(temp->next != q->front)
		{
			temp=temp->next;
		}
		delete q->front;
		q->front=temp;
		q->front->next=NULL;
	}
	q->cnt--;
}

void print(queue * q)
{
	system("cls");
	if(isEmpty(q))
	{
		cout<<"Kuyruk bos"<<endl;
		return;
	}
	else 
	{
		struct node*temp=q->rear;
		while (temp!=NULL)
		{
			cout<<temp->sira<<"("<<temp->adi<<")";
			if(temp->next!=NULL)
			{
				cout<<" -> ";
			}
			temp=temp->next;
		}
	}

	cout<<endl;
}



int main()
{
	queue qu;
	initilize(&qu);	
	int secim,sayi;
	while(1)
	{
		cout<<endl<<"BANKA KUYRUGU UYGULAMASI"<<endl;	
		cout<<"1- Kuyruga Musteri Ekle"<<endl;	
		cout<<"2- Musteriyi Kuyruktan Cikar"<<endl;	
		cout<<"3- Kuyrugu Yazdir"<<endl;	
		cout<<"4- Cikis"<<endl;	
		cout<<"Secim :";
		cin>>sayi;
		switch(sayi)
		{
			case 1:
			 enqueue(&qu);
				break;	
			case 2:
			dequeue(&qu);
				break;
			case 3:
				print(&qu);
				break;
			case 4:
				cout<<"Cikis Yapiliyor...";
				return 0;
		}
	}
	
}
