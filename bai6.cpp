/*nhap n, kiem tra n co la so chinh phuong ko*/
#include<stdio.h>
#include<math.h>
int main()
{
	int n;
	printf("Nhap n=");
	scanf("%d",&n);
	if(sqrt(n)==(int)sqrt(n))
	{
		printf("la SCP");
	} else{
		printf("khong phai SCP");
	}
	return 0;
}
