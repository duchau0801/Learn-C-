#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#define s1 1000
#include <stdbool.h> 
void nhapMang(int a[], int &n)
{
	printf("\nNhap so phan tu: ");
	scanf("%d",&n);
	srand(time (0));
	for(int i=0; i<n; i++)
	    a[i]= rand()%100+ 10;
}
void xuatMang(int a[], int n)
{
	for(int i=0; i<n; i++)
	{
	    printf("%4d", a[i]);	
	} 
}
void xuatChan(int a[], int n)
{
	for(int i=0; i<n; i++)
	{
		if (a[i] % 2 == 0)
		printf("%4d",a[i]);
	}
}
int tongMang(int a[], int n)
{
	long tong=0;
	for(int i=0;i<n;i++)
	{
		tong=tong+a[i];
	}
	printf("\nTong= %ld ",tong);
}
bool KTNT(int n){
	int demUoc=0;
	for(int i=1; i<n; i++){
		if(n%i==0)
		   demUoc++;
	}
	if(demUoc==2)
	   return true;
	return false;
}
void  lietKeSNT(int a[], int n){
	printf("\nCac snt trong mang: ");
	for(int i=0; i<n; i++){
		if(KTNT(a[i])== true)
		printf("%d\t",a[i]);
    }
}
void demChan(int a[], int n)
{
	int dem=0;
	for(int i=0; i<n; i++)
	{
		if(a[i]%2==0)
		   dem++; 
	}
	printf("\nSo luong so chan la: ");
	printf("%d",dem);
}
int nhonhat(int a[], int n)
{
	int min=a[0];
	for(int i=1; i<n; i++)
	{
		if(a[i]<min)
		min=a[i];
	} 
	printf("\nGia tri nho nhat: %d", min);
}
void xuatnhonhat(int a[], int n)
{
	int min=nhonhat(a,n);
	for(int i=0;i<n;i++)
	{
		if(a[i]==min)
		   printf("\na[%d]=%d",i,a[i]);
	}
}
void xuatmangnguoc(int a[], int n)
{
	printf("\nXuat mang nguoc: ");
	for(int i=n-1;i>=0;i--)
	   printf(" %d ",a[i]);
}
int vitri(int a[],int n)
{
	for(int i=n-1;i<n;i++)
	{
		if(i%2==0)
		{
			printf("\na[%d]=%d",i,a[i]);
		}else
		return -1;
	}
}
int main()
{
	int n;
	int a[s1];
	nhapMang(a,n);
	printf("\nNhap mang da nhap la: ");
	xuatMang(a,n);
	printf("\nCac phan tu chan la: ");
	xuatChan(a,n);
	tongMang(a,n);
	lietKeSNT(a,n);
	demChan(a,n);
	nhonhat(a,n);
	xuatnhonhat(a,n);
	xuatmangnguoc(a,n);
	vitri(a,n);
	return 0;
}
