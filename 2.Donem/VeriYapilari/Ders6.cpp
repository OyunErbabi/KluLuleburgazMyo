#include <iostream>
using namespace std;

struct node
{
    int data;
    struct node * next;
};

struct node*basaekle(int key, struct  node*head)
{
    if(head==NULL)
    {
        struct node*temp = new node();
        temp->data=key;
        temp->next=NULL;
        head=temp;
    }
    else 
    {
        struct node*temp = new node();
        temp->data=key;
        temp->next=head;
        head=temp;
    }

    return head;
}

struct node*sonaekle(int key,struct  node*head)
{
    
    if(head==NULL)
    {
        struct node*temp = new node();
        temp->data=key;
        temp->next=NULL;
        head=temp;
    }
    else 
    {   
        struct node*temp = new node();        
        temp->data=key;
        temp->next=NULL;
        struct node*temp2=head;
        while(temp2->next!=NULL)
        {
            temp2=temp2->next;
        }
        temp2->next=temp;
    }

    return head;
};

void yazdir(struct node*head)
{
    system("cls");
    if(head==NULL)
    {
        cout<<"Liste bos, yazdirilacak veri yok.";        
    }
    else
    {
        struct node*temp=head;
        while (temp!=NULL)
        {
            cout<<temp->data<<" ";
            temp=temp->next;
        }
    }
}

void bilgiyazdir(struct node*head)
{
    if(head==NULL)
    {
        cout<<"Liste bos, yazdirilacak veri yok.";  
    }
    else 
    {
        struct node*temp=head;
        int i=1;
        while (temp!=NULL)
        {
            cout<<i<<". dugumun verisi: "<<temp->data<<endl;
            cout<<i<<". dugumun adresi "<<temp<<endl;
            cout<<"Sonraki dugumun adresi: "<<temp->next<<endl;
            temp=temp->next;
            i++;
        }
    }
}

void ara(int aranan, struct node*head)
{    
    bool sonuc = false;
    if(head==NULL)
    {
        cout<<"Liste bos, veri aranamaz.";
    }
    else 
    {
        int index=0;
        struct node*temp=head;
        while(temp!=NULL)
        {
            index++;
            if(temp->data=aranan)
            {
                sonuc=true;
                break;;
            }
            temp=temp->next;
        }
        if(sonuc)
        {
            cout<<"Sayi var. Dugumdeki Sirasi: "<<index<<endl;
        }
        else
        {
            cout<<"Aranan sayi listede bulunmadi.";
        }

    }
}

int adet(struct node*head)
{
    int adet =0;
    if(head==NULL)
    {
        cout<<"Liste Bos";
    }
    else 
    {
        struct node*temp;
        while (temp!=NULL)
        {
            adet++;
            temp=temp->next;
        }
        
    }
    return adet;
}

struct node*bastansil(struct node*head)
{
    if(head==NULL)
    {
        cout<<"Liste bos silinecek eleman yok.";
    }
    else 
    {
        if (head->next==NULL){
            delete head;
            head=NULL;
            cout<<"Listedeki tek dugum silindi.";
        }
        else 
        {
            struct node*temp=head->next;
            delete head;
            head=temp;
        }
    }
    return head;
};

struct node*sondansil(struct node*head)
{
    if(head==NULL)
    {
        cout<<"Dugum bos eleman silinmedi";
    }
    else 
    {
        if(head->next==NULL)
        {
            delete head;
            head=NULL;
            cout<<"Listenin tek elemai silindi.";
        }
        else
        {
            struct node*temp=head;
            while(temp->next->next!=NULL)
            {
                temp=temp->next;
            }
            struct node*temp2=temp;
            delete temp->next;
            temp2->next=NULL;
            cout<<"Listenin sonundaki dugum silindi..";
        }
    }
    return head;
}


int main()
{
    setlocale(LC_ALL, "Turkish"); 
    struct node*head=NULL;    
    int sayi, secim,n;
    while(1)
    {
        cout<<endl;
        cout<<"LISTE UYGULAMASI"<<endl;
        cout<<"1- Basa Ekle"<<endl;
        cout<<"2- Sona Ekle"<<endl;
        cout<<"3- Adet Yazdir"<<endl;
        cout<<"4- Veri Yazdir"<<endl;
        cout<<"5- Tum Bilgileri Yazdir"<<endl;
        cout<<"6- Veri Ara"<<endl;
        cout<<"7- Bastan Sil"<<endl;
        cout<<"8- Sondan Sil"<<endl;
        cout<<"9- Cikis Yap"<<endl<<endl;
        cout<<"Seciminiz :";
        cin>>secim;

        switch (secim)
        {
            case 1:
            cout<<"Basa eklenecek sayi :";
            cin>>sayi;
            head=basaekle(sayi,head);
            break;
            case 2:
            cout<<"Sona eklenecek say, :";
            cin>>sayi;
            head=sonaekle(sayi,head);
            break;
            case 3:
            n=adet(head);
            cout<<"Listedeki Dugum Adeti :"<<n<<endl;
            break;
            case 4:
            yazdir(head);
            break;
            case 5:
            bilgiyazdir(head);
            break;
            case 6:
            cout<<"Aradiginiz sayi: ";
            cin>>sayi;
            ara(sayi,head);
            break;
            case 7:
            head = bastansil(head);            
            break;
            case 8:
            head = sondansil(head);
            break;
            case 9:
            cout<<"Program Sonlandi.";
            return 0;
        }
    }



}