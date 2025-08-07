//Nguyen Duc Hau 2380600613
#include<stdio.h>
#include<string.h>
#define MAX 100;
typedef struct BUUKIEN
{
	char mabuukien[21];
	char nguoigui[21];
	char nguoinhan[21];
	char ngaygui[11];
	char noidungkienhang[100];
	float trongluong;
	float dongiagui;

}BK;
//=======================================
float giatriBK(BK b);
void nhapthongtinBuuKien(BK &b)
{
	printf("Nhap ma buu kien:"); scanf("%s", &b.mabuukien);
	fflush(stdin);
	printf("Nhap ten nguoi gui:"); gets(b.nguoigui);
	fflush(stdin);
	printf("Nhap ten nguoi nhan:"); gets(b.nguoinhan);
	fflush(stdin);
	printf("Nhap ngay gui hang (dd/mm/yyyy):"); gets(b.nguoigui);
	fflush(stdin);
	printf("Nhap noi dung kien hang:"); gets(b.noidungkienhang);
	fflush(stdin);
	printf("Nhap trong luong hang:"); scanf("%f", &b.trongluong);
	printf("Nhap don gia gui:"); scanf("%f", &b.dongiagui);
}
//=======================================
void xuatthongtinBuuKien(BK &b)
{
	printf("%s\t%s\t%s\t%s\t%s\t%.2f\t%.2f\t%.2f\n", b.mabuukien, b.nguoigui, b.nguoinhan, b.nguoigui, b.noidungkienhang, b.trongluong, b.dongiagui, giatriBK(b));
}
//=======================================
void NhapN(int &n)
{
	do{
		printf("Nhap so buu kien:"); scanf("%d", &n);
	}while(n<0 || n>100);
} 
void nhapmangBK(BK b[], int n)
{
	for(int i=0; i<n; i++)
	{
	    printf("BUU KIEN THU: %d\n",i);
		nhapthongtinBuuKien(b[i]);  	
	}
}
void xuatmangBK(BK b[], int n)
{
	for(int i=0; i<n; i++)
	    xuatthongtinBuuKien(b[i]);
}
//=======================================
void themBK(BK b[], int &n)
{
	printf("Nhap them 1 buu kien\n");
	nhapthongtinBuuKien(b[n]);
	n++;
}
//=======================================
void sapxepBuuKien(BK b[], int n)//sap xep tang dan ma buu kien
{
	for(int i=0; i<(n-1); i++)
	   for(int k=i+1; k<n; k++)
	      if(strcmp(b[i].mabuukien , b[k].mabuukien) >0 )
	      {
	      	BK tam=b[i];
	      	b[i]=b[k];
	      	b[k]=tam;
		  }
}
//=======================================
float giatriBK(BK b)
{
	return b.trongluong*b.dongiagui;
}
//=======================================
float trongluongMAX(BK b[], int n)
{
	float max=b[0].trongluong;
	for(int i=0; i<n; i++)
	   if(b[i].trongluong >max) max=b[i].trongluong;
	   return max;
}
int demtrongluongMAX(BK b[], int n)
{
	float max=trongluongMAX(b,n);
	int dem=0;
	for(int i=0; i<n; i++)
	   if(b[i].trongluong==max); dem++;
	return dem;
}
//=======================================
//void timBKtheoten(BK b[], int n, char tg[] ) //tg:ten gui
//{
//	for(int i=0; i<n; i++)
//	   if(strcmp(b[i].nguoigui,tg)==0)
//	      xuatthongtinBuuKien(b[i]);
//}
//=======================================
//void xuatBKthang4nam2014(BK b[], int n)
//{
//	for(int i=0; i<n; i++)
//	   if(b[i].ngaygui == 4 && b[i].ngaygui == 2014)
//	     xuatthongtinBuuKien(b[i]);
//}
int main()
{
	int n;
	BUUKIEN a[100];
	NhapN(n);
	nhapmangBK(a,n);
	printf("Mang buu kien vua nhap la:\n");
	xuatmangBK(a,n);
	
//	xuatBKthang4nam2014(b,n);
//	printf("Mang buu kien Thang 4 Nam 2014 nhap la:\n");
//	xuatmangBK(a,n);
	
//	char tgMuontim[21];
//	printf("Nhap ten nguoi gui muon tim: ");
//	fflush(stdin);
//	gets(tgMuontim);
//	timBKtheoten(a,n,tgMuontim);
	
	themBK(a,n);
	printf("\nMang buu kien vua nhap them la:\n");
	xuatmangBK(a,n);
	sapxepBuuKien(a,n);
	printf("Mang buu kien sau khi tang dan theo ma buu kien:\n");
	xuatmangBK(a,n);
	printf("Mang co %d Buu Kien co trong luong lon nhat\n", demtrongluongMAX(a,n));
}
