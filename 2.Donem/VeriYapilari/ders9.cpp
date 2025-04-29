#include <iostream>
using namespace std;

struct node {
	int data;
	struct node*next;
	struct node*prev;
};

struct node*head=NULL;

void basaekle(int key){
	struct node*newnode=new node();
	newnode->data=key;
	if(head==NULL){
		head=newnode;
		head->next=NULL;
		head->prev=NULL;
		//ILK ELEMAN EKLENDI
		cout<<"Ilk eleman eklendi"<<endl;
	}
	else {
		newnode->next=head;
		head->prev=newnode;
		head=newnode;
		cout<<"Basa eleman eklendi"<<endl;
	}	
}

void sonaekle(int key){
	struct node*newnode=new node();
	newnode->data=key;
	if(head==NULL){
		head=newnode;
		head->next=NULL;
		head->prev=NULL;
		cout<<"Ilk eleman eklendi"<<endl;
	}
	else{
		struct node*temp=head;
		while(temp->next !=NULL)
		{
			temp=temp->next;
		}
		
		temp->next=newnode;
		newnode->prev=temp;
		newnode->next=NULL;
		cout<<"Sona eleman eklendi"<<endl;
		
	}
}

void yazdir(){
	if(head==NULL){
		//liste bos
		cout<<"Liste Bos"<<endl;
	}
	else{
		struct node*temp=head;
		while(temp->next!=NULL){
			cout<<temp->data<<" "<<endl;
			temp=temp->next;
		}
		cout<<temp->data<<""<<endl;
	}
}

int main(){
	int sayi,secim;
	while(1){
		cout<<"1 Basa ekle"<<endl;
		cout<<"2 Sonra ekle"<<endl;
		cout<<"3 Yazdir"<<endl;
		cout<<"4 Cikis"<<endl;
		cout<<"Secim :";
		cin>>secim;
		switch(secim){
			case 1:
				cout<<"Sayi Giriniz:";
				cin>>sayi;
				basaekle(sayi);
			break;
			case 2:
				cout<<"Sayi Giriniz:";
				cin>>sayi;
				sonaekle(sayi);
			break;
			case 3:
				yazdir();
			break;	
			case 4:
				return 0;
		}
	}
}























