#include <stdio.h>

int main()
{
    int n, r = 0;
    scanf("%d", &n);
    do
    {
        r += 3 * (n * n + n) / 2;
    } while (--n);

    printf("%d", r);

    return 0;
}