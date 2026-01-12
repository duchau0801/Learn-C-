#include <stdio.h>
//nhap hai sao a va b. tinh va xuat ra man hinh a^b//
int main() {
	
    int a, b;
    long long result = 1;

    printf("Nhap hai so (a va b): ");
    scanf("%d %d", &a, &b);

    for (int i = 0; i < b; i++) {
        result *= a;
    }

    printf("%d^%d = %lld\n", a, b, result);

    return 0;
}

