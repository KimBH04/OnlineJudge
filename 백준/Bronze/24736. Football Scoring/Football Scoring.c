#include <stdio.h>

void S()
{
    int a, b, c, d, e;
    scanf("%d %d %d %d %d", &a, &b, &c, &d, &e);
    printf("%d\n", a * 6 + b * 3 + c * 2 + d + e * 2);
}

int main()
{
    S(); S();
    return 0;
}