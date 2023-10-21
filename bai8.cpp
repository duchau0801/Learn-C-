#include<stdio.h>
int main()
{
	int n, s=0;
	printf("Nhap n: ");
	scanf("%d",&n);
	int i=0;
	while(i<=n){
		if(i%2==0)
		    s=s+i;
		    i++;
	}
	printf("Tong cac so chan tu 0 den %d = %d",n,s);
	return 0;
}
