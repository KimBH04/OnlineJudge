#include <stdio.h>
typedef long long int ll;

ll GCD(ll a, ll b)
{
    while (b)
    {
        ll r = a % b;
        a = b;
        b = r;
    }

    return a;
}

int main()
{
    ll a, b, gcd;
    scanf("%lld %lld", &a, &b);
    if (a < b)
    {
        ll temp = a;
        a = b;
        b = temp;
    }
    
    printf("%lld", a * b / GCD(a, b));
    return 0;
}