#include <stdio.h>
#include <math.h>
//
void ttsv()
{
	printf("THONG TIN SINH VIEN\n");
	printf("MSSV:2380600613\n");
	printf("HoVaTen:Nguyen Duc Hau\n");
}
//so nuyen to nho hon n 
bool KTNT(int n)
{
    if(n<2) return false;
    int sq = sqrt(n);
    for(int i=2;i <=sq ;i++){
        if(n % i == 0){
            return false;
        }
    }
    return true;
}
void lietkesntnhohonN(int n)
{
	 for(int i=1;i<n;i++){
        if(KTNT(i) == true)
         printf("%d ", i);
    }
}
void nhapN(int &n)
{
	printf("Nhap n:");
    scanf("%d", &n);
 } 
 //UCLN 
int UCLN(int a, int b)
{
    while (b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
int main()
{
	int a,b,n;
	ttsv();
    nhapN(n);
    lietkesntnhohonN(n);
    printf("\nNhap gia tri cua a: ");
    scanf("%d", &a);
    printf("\nNhap gia tri cua b: ");
    scanf("%d", &b);
    printf("Uoc chung lon nhat cua %d và %d là %d\n", a, b, UCLN(a, b));
	return 0;
}
