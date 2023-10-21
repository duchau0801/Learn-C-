/*nhap a b c, tim so lon nhat*/
#include<stdio.h>
int main()
{
	int a,b,c,max;
	printf("Nhap so a: ");
	scanf("%d",&a);
	printf("nhap so b: ");
	scanf("%d",&b);
	printf("nhap so c: ");
	scanf("%d",&c);
	if(a>b && a>c)
	{
		printf("max= %d",a);
	} else if(b>c && b>a)
	{
		printf("max=%d",b);
	} else
	    printf("max=%d",c);
	    
	return 0; 
} 
