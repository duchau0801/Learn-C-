/*nhap so luong va gia ban. Tinh tong tien= so luong *gia ban.
neu tong tien >=100.000 thi giam 5%*/


#include<stdio.h>
int main()
{
	int soluong, giaban;
	float tongtien;
	printf("Nhap so luong: ");
	scanf("%d", &soluong);
	printf("Nhap gia ban: ");
	scanf("%d", &giaban);
	tongtien=soluong*giaban;
	if(tongtien>=100000)
	{
		tongtien*=0.95;
	}
	 printf("Tong tien la: %0.f",tongtien);
return 0;	
}
