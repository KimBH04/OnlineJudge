#include <stdio.h>

int main()
{
    int n, a[200000];
    scanf("%d", &n);
    int i;
    for (i = 0; i < n; i++)
    {
        scanf("%d", &a[i]);
        a[i] -= n - i;
    }

    int max = 0;
    while (n--)
    {
        max = a[n] > max ? a[n] : max;
    }

    printf("%d", max);

    return 0;
}