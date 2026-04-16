#include <stdio.h>
#define M(a, b) (a / b + (a % b ? 1 : 0))

int main()
{
    int l, a, b, c, d;
    scanf("%d %d %d %d %d", &l, &a, &b, &c, &d);
    int e = M(a, c);
    int m = M(b, d);
    printf("%d", l - (e > m ? e : m));
    return 0;
}