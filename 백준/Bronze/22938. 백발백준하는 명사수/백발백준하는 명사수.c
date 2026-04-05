#include <stdio.h>
#include <math.h>
typedef long long int ll;

int main()
{
    ll x1, x2, y1, y2, r1, r2, x, y;
    scanf("%lld %lld %lld", &x1, &y1, &r1);
    scanf("%lld %lld %lld", &x2, &y2, &r2);
    
    x = x1 - x2;
    y = y1 - y2;
    double r = sqrt((x * x) + (y * y));

    printf(r < r1 + r2 ? "YES" : "NO");
}