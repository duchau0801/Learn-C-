/*mang 1 chieu*/
#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#define MAX 100
#include <math.h>
//Nhap vao cac phan tu a
int a[1] ;
//nhap n, 5<=n<100
void nhapN(int &n){
	do{
		printf("Nhap n: ");
		scanf("%d",&n);
		if(n<5 || n>=100)
		    printf("Nhap sai, nhap lai n\n");
	}while(n<5 || n>=100);
}
//ham nhap mang
void nhapMang(int a[], int n){
	for(int i=0; i<n; i++){
		printf("a[%d]= ");
		scanf("%d",&a[i]);
	}
}
//ham sinh mang(tu sinh ra mang co n phan tu)
void sinhMang(int a[], int n){
	srand(time(NULL));
	for(int i=0; i<n; i++){
		a[i]= rand()%31 -10;
	}
}
//ham xuat nguoc
void xuatMangnguoc(int a[], int n){
	printf("\nMang xuat nguoc: \n");
	for(int i= n-1; i>=0; i--){
		printf("%d\t",a[i]);
	}
}
//ham xuat mang
void  xuatMang(int a[], int n){
	printf("\nMang vua nhap: ");
	for(int i=0; i<n; i++){
		printf("%d\t",a[i]);
	}
}
//liet ke (xuat) ra cac so chan trong mang
void  xuatChan(int a[], int n){
	printf("\nCac so chan trong mang: ");
	for(int i=0; i<n; i++){
		if(a[i]%2==0)
		printf("%d\t",a[i]);
	}
}
//liet ke cac snt trong mang
bool KTNT(int n){
	int demUoc=0;
	for(int i=1; i<=n; i++){
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
//dem snt trong mang
int demNT(int a[], int n){
	int dem=0;
	for(int i=0; i<n; i++){
		if(KTNT(a[i])==true)
			dem++;
	}
	return dem;
}
//tong cac snt trong mang
int tongNT(int a[], int n){
	int tong=0;
	for(int i=0;i<n;i++){
		if(KTNT(a[i])== true)
		   tong= tong+a[i];  
	}
	return tong;
}
//liet ke so hoan hao trong mang
bool KTHH(int n){
	long s=0;
	for(int i=1;i<n;i++){
		if(n%i==0)
		   s=s+i;
	}
	if(s==n)
	   return true;
	return false;   
} 
void  lietKeSHH(int a[], int n){
	printf("\nCac shh trong mang: ");
	for(int i=0; i<n; i++){
		if(KTHH(a[i])== true)
		printf("%d\t",a[i]);
    }
}
//dem shh trong mang
int demHH(int a[], int n){
	int dem=0;
	for(int i=0; i<n; i++){
		if(KTHH(a[i])==true)
			dem++;
	}
	return dem;
}
//tong cac shh trong mang
int tongHH(int a[], int n){
	int tong=0;
	for(int i=0;i<n;i++){
		if(KTHH(a[i])== true)
		   tong= tong+a[i];  
	}
	return tong;
}
/*/liet ke so chinh phuong trong mang
bool KTCP(int n){
	int i= sqrt(n);
	if(i*i==n){
		return true; 
	}else 
	return false; 
}
void  lietKeSCP(int a[], int n){
	printf("\nCac scp trong mang: ");
	for(int i=0; i<n; i++){
		if(KTHH(a[i])== true)
		printf("%d\t",a[i]);
}
*/
//
int main(){
	int n, a[MAX];
	nhapN(n);
	sinhMang(a,n);
	//xuatChan(a,n);
	//xuatMangnguoc(a,n);
	//nhapMang(a,n);
	xuatMang(a,n);
	lietKeSNT(a,n);
	printf("\nCo %d SNT trong mang",demNT(a,n));
	printf("\nTong NT=%d",tongNT(a,n));
	lietKeSHH(a,n);
	printf("\nCo %d SHH trong mang",demHH(a,n));
	printf("\nTong HH=%d",tongHH(a,n));
	//lietKeSCP(a,n);
	return 0;
}


