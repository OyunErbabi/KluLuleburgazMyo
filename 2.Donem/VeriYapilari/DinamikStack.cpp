#include <iostream>
using namespace std;

struct node{
	int data;
	struct node*next;
};

class Stack{
	struct node*top;
	
	public:		
		Stack(){
			top=NULL;
		}		
		void push(int key)
		{
			struct node*newnode=new node();
			newnode->data=key;
			newnode->next=top;
			top=newnode;
			cout<<key<<" stack'e eklendi"<<endl;
		}
		
		void pop() //eleman cikartma
		{
			if(top==NULL){
				cout<<"Stack bos"<<endl;
			}
			else{
				cout<<top->data<<" stackten cikartildi"<<endl;
				struct node*temp=top;
				top=top->next;
				delete temp;
			}			
		}
		
		void print(){
			if(top==NULL){
				cout<<"Stack bos veri yok"<<endl;
			}
			else {
				struct node*temp=top;
				cout<<"**ELEMANLAR**"<<endl;
				
				while(temp!=NULL){
					cout<<temp->data<<endl;
					temp=temp->next;
				}
			}
		}
};

int main(){
	setlocale(LC_ALL,"Turkish");
	Stack stk;
	int secim,sayi;
	while(true){
		cout<<"1- Push"<<endl;
		cout<<"2- Pop"<<endl;
		cout<<"3- Print"<<endl;
		cout<<"4- Cikis"<<endl;
		cin>>secim;
		switch (secim)
		{
			case 1:
				cout<<"Sayi :";
				cin>>sayi;
				stk.push(sayi);
				break;
			case 2:
				stk.pop();
				break;
			case 3:
				stk.print();
				break;
			case 4:
				cout<<"Kapatiliyor.."<<endl;
				return 0;
		}
	}

}
