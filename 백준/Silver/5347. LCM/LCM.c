#include <stdio.h>

typedef long long int ll;

static inline ll gcd(ll a, ll b)
{
    while (b > 0)
    {
        ll tmp = a;
        a = b;
        b = tmp % b;
    }
    return a;
}

int main()
{
    int n;
    scanf("%d", &n);
    while (n --> 0)
    {
        ll a, b;
        scanf("%lld%lld", &a, &b);
        ll g = gcd(a, b);
        printf("%lld\n", a * b / g);
    }
    return 0;
}