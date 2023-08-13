#include <stdio.h>
#define F "%d-%d-%d"

int main()
{
    int n, Y, M, D, r = 0;
    scanf(F, &Y, &M, &D);
    D += Y * 10000 + M * 100;
    scanf("%d", &n);
    while (n--)
    {
        int y, m, d;
        scanf(F, &y, &m, &d);
        d += y * 10000 + m * 100;

        if (d >= D)
        {
            r++;
        }
    }
    printf("%d", r);
    return 0;
}