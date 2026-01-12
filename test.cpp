#include <stdio.h>
void HaNoi(int n, char A, char B, char C)
{
	if (n==1)
	printf("%c -> %c\n", A, C);
	else
	{
		HaNoi (n-1,A,C,B);
		HaNoi(1,A,B,C);
		HaNoi(n-1,B,A,C);
	}
}
int main()
{
	int n;
	scanf("%d",&n);
	char A, B, C;
	HaNoi(n,'A','B','C');
	return 0;
}
