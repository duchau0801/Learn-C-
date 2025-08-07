
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

struct L1{
	char Ma[8];
	char Ten[30];
	double dg;
	char xx[20];
};
void Nhap1H(L1 *x){
	int n;
	printf("Nhap ma: "); scanf("%s",&x->Ma);
	printf("Nhap ten: ");
    scanf("%s",&x->Ten); 
    x->Ten[0] = toupper(x->Ten[0]); getchar();
    fflush(stdin);
	printf("Nhap don gia: "); scanf("%lf",&x->dg);
	getchar();
	printf("Xuat xu: "); gets(x->xx);
}
void Xuat1H(L1 *x){
	printf("Ma: %s\n",x->Ma);
	printf("Ten: %s\n",x->Ten);
	printf("Don gia: %.2lf\n",x->dg);
	printf("Xuat xu: %s\n",x->xx);
}
void NhapDSMH(L1 *x,int n){
	for(int i=0;i<n;i++){
		printf("\nNhap danh sach mat hang: %d\n",i+1);
		Nhap1H(&x[i]);
	}
}
void XuatDSMH(L1 *x,int n){
	for(int i=0;i<n;i++)
	Xuat1H(&x[i]);
}
void SLMH(int &n){
	printf("\nNhap so luong mat hang: \n");
	scanf("%d",&n);
}
void Lietke(L1 *x,int n,char Xx[]){
	printf("\nDanh sach cac mat hang co xuat xu %s:\n",Xx);
	for(int i=0;i<n;i++){
		if(strcmp(x[i].xx,Xx)==0){
			printf("Ma: %s, Ten: %s, Don gia: %.2lf\n",x->Ma,x->Ten,x->dg);
		}
	}
}
void Tim(L1 *x,int n,char ma[]){
	printf("\nTim thong tin mat hang co ma: %s\n",ma);
	gets(ma);
	for(int i=0;i<n;i++){
	if(stricmp(x[i].Ma,ma )==0)
	Xuat1H(&x[i]);
}
}
void Them(L1 *x,int *n){
	printf("\nThem 1 mat hang vao danh sach: \n");
	Nhap1H(&x[*n]);
	*n++;
}
void Xoa(L1 *x, int *n, char maXoa[]) {
    int i, j;
    for (i = 0; i < *n; i++) {
        if (strcmp(x[i].Ma, maXoa) == 0) {
            for (j = i; j < *n - 1; j++) {
                strcpy(x[j].Ma, x[j + 1].Ma);
                strcpy(x[j].Ten, x[j + 1].Ten);
                x[j].dg = x[j + 1].dg;
                strcpy(x[j].xx, x[j + 1].xx);
            }
            (*n)--;
            printf("Mat hang co ma %s da duoc xoa.\n", maXoa);
            return;
        }
    }
    printf("Khong tim thay mat hang co ma %s.\n", maXoa);
}
double GiaCaoNhat(L1 *x, int n, const char *xuatXu) {
    double giaCaoNhat = 0.0;
    for (int i = 0; i < n; i++) {
        if (strcmp(x[i].xx, xuatXu) == 0 && x[i].dg > giaCaoNhat) {
            giaCaoNhat = x[i].dg;
        }
    }
    return giaCaoNhat;
}

int Dem(L1 *x,int n){
	 	int cnt = 0;
	 	for(int i =0;i<n;i++){
	 		if(strcmp(x[i].xx,"VietNam") == 0){
	 			cnt++;
			 }
		 }
		 return cnt;
}
int main()
{
	int n;
	char ma[8], maXoa[8];
	L1 *x;
	SLMH(n);
	x=(L1*)malloc(n*sizeof(L1));
	NhapDSMH(x,n);
	printf("\nDANH SACH MAT HANG VUA NHAP: \n");
	XuatDSMH(x,n);
	
	Lietke(x,n,"Vietnam");
	Lietke(x,n,"China");
	Lietke(x,n,"USA");
	
	Tim(x,n,ma);
	
	Them(x,&n);
	printf("\nDANH SACH MAT HANG VUA THEM: \n");
	XuatDSMH(x,n);
	
	Xoa(x,&n,maXoa);
	
	 double giaCaoNhatVietNam = GiaCaoNhat(x, n, "VietNam");
    if (giaCaoNhatVietNam > 0.0) {
        printf("Gia cao nhat cua cac mat hang co xuat xu Viet Nam la: %.2lf\n", giaCaoNhatVietNam);
    } else {
        printf("Khong co mat hang nao co xuat xu tu Viet Nam.\n");
    }
    
    Dem(x,n);
    free(x);

}

