/*tinh tien luong dua vao gio lam
truoc 12h: 6.000
sau 12h: 7.500*/
#include <stdio.h>
#define GIA1 6000
#define GIA2 7500

void nhapGio(int &g){
	do{
		printf("Nhap gio: ");
		scanf("%d",&g);
		if(g<=5 || g>24)
		   printf("Nhap sai gio, nhap lai\n");
	}while(g<=0 || g>24);
}
double tinhTien(int gioBD, int gioKT){
	double tong=0;
	if(gioBD<12 && gioKT>=12){
		tong= (gioKT- gioBD)*GIA1;
	}
	else if(gioBD>=12 && gioKT>=12){
		tong= (gioKT- gioBD)*GIA2;
	}
	else if(gioBD<12 && gioKT>12){
		double tong1= (12-gioBD)*GIA1;
		double tong2= (gioKT-12)*GIA2;
		tong= tong1+tong2;
	}
	else{
	    tong=-1;
	}
	return tong;
}

int main(){
	int gioBD, gioKT;
	nhapGio(gioBD);
	nhapGio(gioKT);
	printf("\ntong tien: %lf",tinhTien(gioBD,gioKT));
	return 0;
}
