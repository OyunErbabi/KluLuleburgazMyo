#include <iostream>
using namespace std;


struct cagri{
    int cagriID;
    string arayanNumara;
    struct cagri*next;
};

struct cagrikuyrugu{
    int cnt;
    struct cagri*front;
    struct cagri*rear;
};

void initialize(cagrikuyrugu * q){
    q->cnt=0;
    q->front=NULL;
    q->rear=NULL;
};

bool isEmpty(cagrikuyrugu *q){
    return(q->cnt==0);
}

void enqueue(cagrikuyrugu*q, int cagriID, string arayanNumara){
    struct cagri*yenicagri = new cagri();
    yenicagri->cagriID=cagriID;
    yenicagri->arayanNumara=arayanNumara;
    yenicagri->next=NULL;
    if(isEmpty(q)){
        q->front=yenicagri;
        q->rear=yenicagri;
        cout<<arayanNumara<<" nolu kayit kuyruga eklendi. ID: "<<cagriID<<endl;
    }
    else {
        q->rear->next=yenicagri;
        q->rear=yenicagri;
        cout<<arayanNumara<<" nolu kayit kuyruga eklendi. ID: "<<cagriID<<endl;
    }
    q->cnt++;
}

void dequeue(cagrikuyrugu*q){
    if(isEmpty(q))
    {
        cout<<"Kuyruk bos cagri yok.";
    }
    else 
    {
        struct cagri*islenencargri=q->front;
        cout<<"Islenen Cagri ID: "<<islenencargri->cagriID<<endl;
        cout<<"Islenen Cagri NO: "<<islenencargri->arayanNumara<<endl;
        q->front=q->front->next;
        delete islenencargri;
        q->cnt--;
        if(q->cnt==0)
        {
            q->rear=NULL;
        }
    }
}


void print(cagrikuyrugu*q)
{
    system("cls");
    cout<<"--CAGRI KUYRUGU--"<<endl<<endl;

    if(isEmpty(q))
    {
        cout<<"Kuyruk bos, bekleyen cagri yok.";
    }
    else 
    {
        struct cagri*temp=q->front;
        while (temp!=NULL)
        {
            cout<<"ID: "<<temp->cagriID<<endl;
            cout<<"No: "<<temp->arayanNumara<<endl;
            temp=temp->next;
        }
    }
}

int main(){
    cagrikuyrugu kuyruk;
    initialize(&kuyruk);
    int secim, id=1;
    string araynno;

    while(1){
        cout<<"--CAGRI KUYRUGU UYGULAMASI--"<<endl<<endl;
        cout<<"1- Cagri Ekle"<<endl;
        cout<<"2- Cagri Isle"<<endl;
        cout<<"3- Cagrida Bekleyenleri Yazdir"<<endl;
        cout<<"4- Cikis Yap"<<endl<<endl;
        cout<<"Secim: ";
        cin>>secim;

        switch (secim)
        {
            case 1:
                cout<<"Arayan No: ";
                cin>>araynno;                
                enqueue(&kuyruk,id,araynno);
                id++;
            break;
            case 2:
                dequeue(&kuyruk);                
            break;
            case 3:
                print(&kuyruk);
            break;
            case 4:
                cout<<"Cikis Yapiliyor...";
                return 1;
            break;
        }

    }
}
