#include <stdio.h>

int main()
{
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    int e = a + d - b - c;
    if (e < 0)
    {
        e = -e;
    }
    printf("%d", e);
    return 0;
}