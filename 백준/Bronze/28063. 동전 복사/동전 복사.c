#include <stdio.h>

int main()
{
    int n, x, y, r = 0;
    scanf("%d", &n);
    scanf("%d %d", &x, &y);

    if (x - 1 > 0)
    {
        r++;
    }
    if (x + 1 <= n)
    {
        r++;
    }
    if (y - 1 > 0)
    {
        r++;
    }
    if (y + 1 <= n)
    {
        r++;
    }

    printf("%d", r);
    return 0;
}