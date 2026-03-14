#include <stdio.h>
#include <stdlib.h>
#define M 1000000007
typedef unsigned long long int ull;

ull pow_mod(ull n, ull p)
{
    ull result = 1;
    while (p > 0)
    {
        if (p & 1)
        {
            result *= n;
            result %= M;
            p--;
        }
        n *= n;
        n %= M;
        p >>= 1;
    }
    return result;
}

int main()
{
    int n, k;
    scanf("%d%d", &n, &k);
    ull *f = (ull*)malloc(sizeof(ull) * (n + 1));
    f[0] = 1;

    for (int i = 1; i <= n; i++)
    {
        f[i] = (f[i - 1] * i) % M;
    }

    printf("%llu", f[n] * pow_mod(f[k] * f[n - k] % M, M - 2) % M);

    free(f);
    return 0;
}