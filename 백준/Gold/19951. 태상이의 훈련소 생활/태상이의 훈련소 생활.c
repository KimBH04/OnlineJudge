#include <stdio.h>

int main()
{
    int n, m, h[100001], dirt[100002] = {0}, a, b, k, sum = 0;
    scanf("%d%d", &n, &m);
    for (int i = 1; i <= n; i++)
    {
        scanf("%d", h + i);
    }
    while (m--)
    {
        scanf("%d%d%d", &a, &b, &k);
        dirt[a] += k;
        dirt[b + 1] -= k;
    }
    for (int i = 1; i <= n; i++)
    {
        sum += dirt[i];
        printf("%d ", h[i] + sum);
    }
    return 0;
}