#include <stdio.h>
#include <math.h>

inline int max(int a, int b)
{
    return a > b ? a : b;
}

int main()
{
    int a, t;
    scanf("%d%d", &a, &t);
    printf("%d", max(10 + 2 * (25 - a + t), 0));
    return 0;
}