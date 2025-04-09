#include <iostream>
using namespace std;

struct Personel
{
	int PersonelNo;
	string PersonelAd;
	string PersonelSoyad;
	float PersonelMaas;
	struct Personel*Next;	
};

void AnaMenu()
{
	cout<<"Lüleburgaz MYO Personel Kayıt Uygulaması"<<endl<<endl;
	
	cout<<"1- Yeni Kayıt Oluştur"<<endl;
	cout<<"2- Listenin Başından Kayıt Sil"<<endl;
	cout<<"3- Listenin Sonundan Kayıt Sil"<<endl;
	cout<<"4- Personel Ara"<<endl;
	cout<<"5- Tüm Kayıtlı Personel Bilgilerini Getir"<<endl;
	cout<<"0- Çıkış Yap"<<endl<<endl;	
	cout<<"Seçiminiz: ";
}

struct Personel*YeniKayit(struct Personel*head)
{
	system("cls");
	int _numarasi;
	string _ad;
	string _soyad;
	float _maas;
	cout<<"Kaydı yapılacak personelin bilgilerini giriniz :"<<endl<<endl;
	
	for(int i=0;i<4;i++)
		{
			switch(i)
			{
				case 0:
					cout<<"Numara\t:";
					cin>>_numarasi;
					break;
				case 1:
					cout<<"Adı\t:";
					cin>>_ad;					
					break;
				case 2:
					cout<<"Soyadi\t:";
					cin>>_soyad;
					break;
				case 3:
					cout<<"Maaş\t:";
					cin>>_maas;
					break;
			}	
		}	
		
	struct Personel*temp = new Personel();
	temp->PersonelNo=_numarasi;
	temp->PersonelAd=_ad;
	temp->PersonelSoyad=_soyad;
	temp->PersonelMaas=_maas;	
	temp->Next=NULL;
	
	if(head==NULL)
	{		
		head=temp;
		cout<<_numarasi<<" numaralı personel listedeki ilk kayda eklendi."<<endl<<endl;
	}
	else 
	{
		int sira=2;
		struct Personel*temp2=head;
		while(temp2->Next!=NULL){
			sira++;
			temp2=temp2->Next;
		}
		temp2->Next=temp;		
		cout<<_numarasi<<" numaralı personel listedeki "<<sira<<". sıraya eklendi."<<endl<<endl;
	}
	
	return head;
}

void BilgileriGetir(struct Personel*head)
{
	system("cls");
	if(head==NULL)
	{
		cout<<"Yazdırılacak personel bilgisi bulunamadı. Liste Boş!"<<endl<<endl;	
	}
	else 
	{
		struct Personel*temp=head;		
		while(temp!=NULL)
		{
			cout<<temp->PersonelNo<<" numaralı personele ait bilgiler şöyledir:\n\nAd\t:"<<temp->PersonelAd<<endl<<"Soyad\t:"<<temp->PersonelSoyad<<endl<<"Maaş\t:"<<temp->PersonelMaas<<endl<<endl;
			temp=temp->Next;	
		}
	}
}

struct Personel*BastanKayitSil(struct Personel*head)
{
	system("cls");
	if(head==NULL)
	{
		cout<<"Kayıt Silinemedi: Liste Boş!"<<endl<<endl;	
	}	
	else 
	{
		if(head->Next==NULL)
		{
			delete head;
			head=NULL;
			cout<<"Personel listesindeki ilk eleman silindi. Liste artık boş!"<<endl<<endl;
		}
		else 
		{
			struct Personel*temp=head->Next;
			delete head;
			head=temp;	
			cout<<"Personel listesindeki ilk eleman silindi"<<endl<<endl;
		}
	}
	return head;
}

struct Personel*SondanKayitSil(struct Personel*head)
{
	system("cls");
	if(head==NULL)
	{
		cout<<"Kayıt Silinemedi: Liste Boş!"<<endl<<endl;	
	}	
	else 
	{
		if(head->Next==NULL)
		{
			delete head;
			head=NULL;
			cout<<"Personel listesindeki tek kayıt silindi. Liste artık boş!"<<endl<<endl;
		}
		else 
		{
			struct Personel*temp=head;
			while(temp->Next->Next!=NULL)
			{
				temp=temp->Next;	
			}
			struct Personel*temp2=temp;
			delete temp->Next;
			temp2->Next=NULL;
			cout<<"Listenin sonundaki personel başarıyla silindi."<<endl<<endl;
		}
	}
	return head;
}

void PersonelAra(struct Personel*head)
{
	system("cls");
	if(head==NULL)
	{
		cout<<"Personel Listesi Boş Arama Yapılamaz"<<endl<<endl;
	}
	else 
	{
		int _personelNo;
		cout<<"Aramak istediğiniz personelin numarasını girin: ";
		cin>>_personelNo;
	
		system("cls");
			
		bool PersonelMevcut=false;		
		struct Personel*temp=head;
		while(temp!=NULL)
		{
			if(_personelNo==temp->PersonelNo)
			{
				cout<<_personelNo<<" numaralı personele ait bilgiler şöyledir:\n\nAd\t:"<<temp->PersonelAd<<endl<<"Soyad\t:"<<temp->PersonelSoyad<<endl<<"Maaş\t:"<<temp->PersonelMaas<<endl<<endl;
				PersonelMevcut=true;
				break;
			}	
			temp=temp->Next;
		}
			
		if(!PersonelMevcut)
		{
			cout<<"Aradığınız numarada bir personel mevcut değil!"<<endl<<endl;	
		}
	}
}

int main()
{
	setlocale(LC_ALL,"Turkish");	
	struct Personel*head=NULL;
	int secim;
	
	while(1)
	{
		AnaMenu();
		cin>>secim;
				
		switch(secim)
		{
			case 0:	return 0;			
			case 1: head=YeniKayit(head); break;
			case 2: head=BastanKayitSil(head); break;
			case 3: head=SondanKayitSil(head); break;
			case 4: PersonelAra(head); break;
			case 5: BilgileriGetir(head); break;
		}
		
	}
	
	return 0;
}
