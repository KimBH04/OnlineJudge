#include <stdio.h>

int main()
{
    int n, r = 0;
    scanf("%d", &n);
    while (n--)
    {
        int x;
        scanf("%d", &x);
        r += x;
    }
    printf("%d", r);
    return 0;
}