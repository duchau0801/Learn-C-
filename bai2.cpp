/*
nhap vao 3 canh, kiem tra 3 canh do co tao thanh tam giac khong, neu co hayx tinh chu vi va dien tich tam giac
*/
#include<stdio.h>
#include<math.h>
//ham chinh cua chuong trinh
int main()
{
	float a,b,c, cv, dt,p;
//Nhap ba so nguyen a, b va c	
	printf("a=");
	scanf("%f",&a);
	printf("b=");
	scanf("%f",&b);
	printf("c=");
	scanf("%f",&c);
//kiem tra ba canh co tao thanh tam giac khong
    if(a>0 && b>0 && c>0 && a+b>c && b+c>a && a+c>b)
    {
    	cv= a+b+c;
    	p= (a+b+c)/2; 
    	dt= sqrt(p*(p-a)*(p-b)*(p-c)) ;
		printf("Chu vi tam giac: %f", cv);
		printf("\nDien tich tam giac: %f", dt); 
	}
	else{
		printf("Ba canh tren khong tao thanh tam giac");
	}
	return 0;
}

