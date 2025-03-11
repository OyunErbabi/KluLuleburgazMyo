#include <iostream>
using namespace std;


struct kitap{
	int KitapNo;
	string KitapAdi;
	string KitapYazari;
	string YayinEvi;
	int SayfaSayisi;
	struct kitap*next;
};


int main()
{
	setlocale(LC_ALL,"Turkish");
	
	struct kitap*kitap1 = new kitap();
	struct kitap*kitap2 = new kitap();
	struct kitap*kitap3 = new kitap();
	kitap1->KitapNo=1;
	kitap1->KitapAdi="Leyla ile Mecnun";
	kitap1->KitapYazari="Burak Aksak";
	kitap1->YayinEvi="Küsürat Yayýncýlýk";
	kitap1->SayfaSayisi=270;
	kitap1->next=kitap2;
	
	kitap2->KitapNo=2;
	kitap2->KitapAdi="1 Yeni Bildiriminiz Var";
	kitap2->KitapYazari="Yavuz Samur";
	kitap2->YayinEvi="Nemesis Yayýncýlýk";
	kitap2->SayfaSayisi=240;
	kitap2->next=kitap3;
	
	kitap3->KitapNo=3;
	kitap3->KitapAdi="Bilgisayar Donanýmý";
	kitap3->KitapYazari="Ebubekir Yaþar";
	kitap3->YayinEvi="Ekin Yayýncýlýk";
	kitap3->SayfaSayisi=357;
	kitap3->next=NULL;
	
	struct kitap * gecici = kitap1;
	
	while(gecici!=NULL)
	{
		cout<<gecici->KitapNo<<" nolu kitaba dair bilgiler aþaðýda belirtilmiþtir."<<endl<<endl
		<<"Kitap Adý: "<<gecici->KitapAdi<<endl
		<<"Kitabýn Yazarý: "<<gecici->KitapYazari<<endl
		<<"Kitabýn Yayýnevi: "<<gecici->YayinEvi<<endl
		<<"Kitabýn Sayfa Sayýsý: "<<gecici->SayfaSayisi<<endl<<endl;
		
		gecici=gecici->next;	
	}
	
	return 0;	
}




