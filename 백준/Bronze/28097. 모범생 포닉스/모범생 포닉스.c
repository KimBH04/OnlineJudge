#include <stdio.h>

int main()
{
    int n, r = 0;
    scanf("%d", &n);
    r += (n - 1) * 8;

    while (n--)
    {
        int t;
        scanf("%d", &t);
        r += t;
    }

    printf("%d %d", r / 24, r % 24);

    return 0;
}