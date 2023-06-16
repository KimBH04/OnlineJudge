#include <stdio.h>

int main()
{
    int a, m, x = 1;
    scanf("%d %d", &a, &m);
    while (a * x % m != 1)
    {
        x++;
    }
    printf("%d", x);
    return 0;
}