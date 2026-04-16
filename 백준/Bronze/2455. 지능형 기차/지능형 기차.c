#include <stdio.h>

int main()
{
    int i, r, m;
    i = r = m = 0;
    for (; i < 4; i++)
    {
        int a, b;
        scanf("%d %d", &a, &b);
        r += b - a;
        m = m > r ? m : r;
    }

    printf("%d", m);
    return 0;
}