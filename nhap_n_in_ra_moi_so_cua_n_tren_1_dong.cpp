/*nhap n, in ra moi chu so cua n tren moi dong
in ra theo chieu nguoc*/
#include<stdio.h>

void inracacchusocuaN(int n)
{
	while(n>0){
		int dv=n%10;
		printf("%d\n",dv);
		n=n/10;
	}
} 
void nhapN(int &n){
	printf("Nhap n= ");
	scanf("%d",&n);
   }
int main(){
	int n;
	nhapN(n);
	inracacchusocuaN(n);
	return 0;
}
