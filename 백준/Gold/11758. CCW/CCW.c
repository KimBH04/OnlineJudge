#include <stdio.h>

int main()
{
    int x1, y1, x2, y2, x3, y3;
    scanf("%d%d%d%d%d%d", &x1, &y1, &x2, &y2, &x3, &y3);

    x1 = x2 - x1;
    y1 = y2 - y1;
    x2 = x3 - x2;
    y2 = y3 - y2;

    int z = x1 * y2 - x2 * y1;
    if      (z > 0) printf("1");
    else if (z < 0) printf("-1");
    else            printf("0");
    return 0;
}