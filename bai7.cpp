/*nhap so ba chu so, in ra ket qua doc cua no*/
#include<stdio.h>
#include<conio.h>
#include<math.h>
int main()
{
	int n;
	do{
		printf("n=");
		scanf("%d", &n);
		if(n<100 || n>999){
			printf("nhap sai, nhap lai ");
		}
	} while (n<100 || n>999);
	int tram=n/100;
	int chuc=n/10%10;
	int dv=n%10;
	switch(tram){
		case 0: printf("linh"); break;
		case 1: printf("mot tram"); break;
		case 2: printf("hai tram"); break;
		case 3: printf("ba tram"); break;
		case 4: printf("bon tram"); break;
		case 5: printf("nam tram"); break;
		case 6: printf("sau tram"); break;
		case 7: printf("bay tram"); break;
		case 8: printf("tam tram"); break;
		case 9: printf("chin tram"); break;
		default : printf("khong hop le"); return 0;
	}
	switch(chuc){
		case 0: 
		if(dv!=0){
			printf("linh"); break;
		}else 
		{
			printf(" "); break;
		}
		case 1: printf(" muoi"); break;
		case 2: printf(" hai muoi"); break;
		case 3: printf(" ba muoi"); break;
		case 4: printf(" bon muoi"); break;
		case 5: printf(" nam muoi"); break;
		case 6: printf(" sau muoi"); break;
		case 7: printf(" bay muoi"); break;
		case 8: printf(" tam muoi"); break;
		case 9: printf(" chin muoi"); break;
		default : printf("khong hop le"); return 0;
	}
	switch(dv){
		case 0: printf(" "); break;
		case 1: printf(" mot"); break;
		case 2: printf(" hai"); break;
		case 3: printf(" ba"); break;
		case 4: printf(" bon"); break;
		case 5: printf(" nam"); break;
		case 6: printf(" sau"); break;
		case 7: printf(" bay"); break;
		case 8: printf(" tam"); break;
		case 9: printf(" chin"); break;
		default : printf("khong hop le"); return 0;
	}
	return 0;
}
