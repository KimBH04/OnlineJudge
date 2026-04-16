#include <stdio.h>

int main()
{
    int n, x[10000];
    scanf("%d", &n);
    for (int i = 0; i < n; i++)
    {
        scanf("%d", x + i);
    }
    long long int s = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            s += (x[i] - x[j]) * (x[j] > x[i] ? -1 : 1);
        }
    }
    printf("%lld", s);
    return 0;
}