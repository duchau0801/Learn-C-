#include<stdio.h>
int main()
{
	int gio, phut, giay;
	printf("nhap gio, phut giay: ");
	scanf("%d %d %d", &gio, &phut, &giay);
	if(gio<24 && phut<60 && giay<60)
	{
		printf("hop le");
	} else
	{
		printf("ko hop le");
	}
	return 0;
} 
