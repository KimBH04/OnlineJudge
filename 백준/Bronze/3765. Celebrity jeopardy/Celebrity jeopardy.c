#include <stdio.h>

int main()
{
	char s[10000];
	while (scanf("%s", s) != -1)
	{
		printf("%s\n", s);
	}
}