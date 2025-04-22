#include <iostream>
using namespace std;

struct node{
	int data;
	struct node*next;
};

struct node*head=NULL;

void basaekle(int key)
{
	struct node*newnode = new node();
	newnode->data=key;
	if(head == NULL) //yani liste bos ise
	{
		head=newnode;
		head->next=head;
		cout<<head->data<<" ilk kayit olarak eklendi."<<endl;		
	}
	else 
	{
		if(head->next==head) //tek dugum var ise
		{
			newnode->next=head;
			head->next=newnode;
			head=newnode;
			cout<<head->data<<" verisi basa eklendi"<<endl;
		}	
		else 
		{
			struct node*temp=head;
			while(temp->next!=head)
			{
				temp=temp->next;	
			}	
			newnode->next=head;
			head=newnode;
			temp->next=head;
			cout<<head->data<<" verisi basa eklendi"<<endl;
		}
	}
}


void sonaekle(int key)
{
	struct node*newnode = new node();
	newnode->data=key;
	if(head == NULL) //yani liste bos ise
	{
		head=newnode;
		head->next=head;
		cout<<head->data<<" ilk kayit olarak eklendi."<<endl;		
	}
	else 
	{
		if(head->next==head) //tek dugum var ise
		{
			head->next=newnode;
			newnode->next=head;
			cout<<newnode->data<<" verisi basa eklendi"<<endl;
		}	
		else 
		{
			struct node*temp=head;
			while(temp->next!=head)
			{
				temp=temp->next;	
			}	
			temp->next=newnode;
			newnode->next=head;			
			cout<<newnode->data<<" verisi basa eklendi"<<endl;
		}
	}
}


void bastansil(){
	if(head==NULL)
	{
		cout<<"Liste bos silinecek bir sey yok"<<endl;
	}
	else 
	{
		if(head->next==head)
		{
			delete head;
			head=NULL;
			cout<<"Tek dugum silindi"<<endl;			
		}
		else 
		{
			struct node*temp=head;
			while(temp->next!=head)
			{
				temp=temp->next;	
			}
			struct node*temp2=head->next;
			delete head;
			head=temp2;
			temp->next=head;
			cout<<"Bastaki dugum silindi"<<endl;
		}
	}
}

void sondansil()
{
	if(head==NULL)
	{
		cout<<"Liste bos silinecek bir sey yok"<<endl;
	}
	else 
	{
		if(head->next==head)
		{
			delete head;
			head=NULL;
			cout<<"Tek dugum silindi"<<endl;			
		}
		else 
		{
			struct node*temp=head;
			while(temp->next->next!=head)
			{
				temp=temp->next;	
			}			
			delete temp->next;
			temp->next=head;
			
			cout<<"Sondaki dugum silindi"<<endl;
		}
	}
}

void yazdir(){
	system("cls");
	struct node*temp=head;
	if(head==NULL){
		cout<<"Liste bos";		
	}
	else 
	{
		while(temp->next!=head)
		{
			cout<<temp->data<<" ";
			temp=temp->next;	
		}
		cout<<temp->data<<" ";
	}
}

void arayaekle(int key,int sayidanonce)
{
	bool sonuc=false;
	struct node*newnode=new node();
	newnode->data=key;
	if(head==NULL){
		head=newnode;
		head->next=head;
		cout<<head->data<<" listeye ilk kayit olarak eklenndi"<<endl;
	}
	else 
	{
		struct node*temp=head;
		while(temp->next!=head)
		{
			if(temp->next->data==sayidanonce)
			{
				struct node*temp2=temp;
				struct node*temp3=temp->next;				
				temp2->next = newnode;
				newnode->next=temp3;
				cout<<"Sayi araya eklendi."<<endl;
				sonuc=true;
				break;
			}	
			temp=temp->next;
		}	
	}
	
	if(!sonuc)
	{
		cout<<"Araya ekleme yapilamadi"<<endl;
	}
}

void aradansil(int key)
{
	bool sonuc=false;	
	
	if(head==NULL){		
		cout<<"Listedeki bos, silinecek veri yok"<<endl;
	}
	else 
	{
		if(head->next==head && head->data==key)
		{
			delete head;
			head=NULL;
			cout<<"Listedeki tek dugum silindi"<<endl;
			sonuc=true;
		}
		else 
		{
			struct node*temp=head;
			while(temp->next!=head)
			{
				if(temp->next->data==key)
				{
					struct node*temp2=temp;
					struct node*temp3=temp->next->next;
					delete temp->next;
					temp2->next=temp3;
					cout<<"Dugum silindi"<<endl;
					sonuc=true;
					break;
				}
				temp=temp->next;
			}
		}
	}
	
	if(!sonuc)
	{
		cout<<key<<" sayisi listeden silinemedi"<<endl;
	}
}

int main()
{
	setlocale(LC_ALL,"Turkish");
	int s1,s2, secim;
	while(1){
		cout<<"**ISLEMLER**"<<endl<<endl;
		cout<<"1- Basa Ekle"<<endl;
		cout<<"2- Sona Ekle"<<endl;
		cout<<"3- Araya Ekle"<<endl;
		cout<<"4- Bastan Sil"<<endl;
		cout<<"5- Sondan Sil"<<endl;
		cout<<"6- Aradan Sil"<<endl;
		cout<<"7- Listeyi Yazdir"<<endl;
		cout<<"0- Cikis Yap"<<endl<<endl;
		cout<<"Secim: ";
		cin>>secim;
		
		switch(secim){
			case 1:
				cout<<"Sayi: ";
				cin>>s1;
				basaekle(s1);
				break;
			case 2:
				cout<<"Sayi: ";
				cin>>s1;
				sonaekle(s1);
				break;
			case 3:
				cout<<"Sayi: ";
				cin>>s1;
				cout<<"Hangi sayýdan önce?: ";
				cin>>s2;
				arayaekle(s1,s2);
				break;
			case 4:
				bastansil();
				break;
			case 5:
				sondansil();
				break;
			case 6:
				cout<<"Sayi: ";
				cin>>s1;
				aradansil(s1);
				break;
			case 7:
				yazdir();
				break;
			case 0:
				cout<<"Program Sonlandý"<<endl;
				return 0;
		}
		
		
	}
}







































































































