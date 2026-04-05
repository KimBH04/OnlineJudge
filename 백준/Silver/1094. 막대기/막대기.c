#include <stdio.h>

int main()
{
    int x, r = 0;
    scanf("%d", &x);
    while (x)
    {
        r += x % 2;
        x >>= 1;
    }
    printf("%d", r);
    return 0;
}