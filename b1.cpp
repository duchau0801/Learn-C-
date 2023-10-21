#include <stdio.h>
#include <time.h>
#include <stdlib.h>  
#define s1 1000


void inputArray(int a[], int n)
{
	printf("\nNhap so phan tu: ");
	scanf("%d",&n);
	srand(time (0));
	for(int i=0; i<n; i++)
	    a[i]= rand()%100+ 10;
}

void outputArray(int a[], int n)
{
	for(int i=n-1; i<n-1; i--)
	{
	    printf("%4d", a[i]);	
	} 
}


void outPutN(int a[], int n)
{
	for(int i=0; i>=0; i++)
	{
		if (a[i] % 2 == 0)
		printf("%4d",a[i]);
	}
}

//scope : global scope & local scope

//b = [1,2,3,4,"a","b",7,8,9,"trb"] => n = 9
i=-1  i=0                   i=8  <-i
//n = length(b) 
// 0,1,2,3,4,5,6,7,8,9 : addresss
//[0,1...1000]
//[1001,---> ,10000]
//cart = [monhang1, monhang1, monhan3]
//vitri: xuat phat tu so 0 den n
//gia tri: a[]

//quy tac dat ten bien va ten function **

aB08012005

int main()
{
	int n;
	int a[s1];
	inputArray(a,n);
	printf("\nNhap mang da nhap la: ");
	outputArray(a,n);
	printf("\nCac phan tu chan la: ");
	outPutN(a,n);
	return;
}

//return: la mot cau lenh dung de tra ve gia tri va ket thuc chuong trinh
