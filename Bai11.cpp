/* 
Nhap hai so nguyen, tinh va in tong, hieu, tich, thuong cua hai so vua nhap
*/
#include <stdio.h>
#include <conio.h>
// ham chinh cua chuong trinh
int main()
{
	//khai bao hai bien so nguyen a va b
	int a,b;
	// nhap hai so a va b
	printf("a=");
	scanf("%d",&a);
	printf("b=");
	scanf("%d",&b);
	//thuc hien phep tinh
	int tong= a+b;
	int hieu= a-b;
	int tich= a*b;
	float thuong= (float)a/b;
	//in ket qua ra man hinh
	printf("%d + %d = %d\n",a,b, tong);
	printf("%d - %d = %d\n",a,b, hieu); 
	printf("%d*%d = %d\n",a,b, tich); 
	printf("%d/%d = %g",a,b, thuong); 
	return 0;
 }
  


 
