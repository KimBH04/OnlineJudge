#include <stdio.h>

typedef long long int ll;

static inline ll ccw(ll x1, ll y1, ll x2, ll y2, ll x3, ll y3)
{
    return (x1 * y2 + x2 * y3 + x3 * y1) - (y1 * x2 + y2 * x3 + y3 * x1);
}

int main()
{
    int x1, y1, x2, y2, x3, y3, x4, y4;
    scanf("%d%d%d%d%d%d%d%d", &x1, &y1, &x2, &y2, &x3, &y3, &x4, &y4);
    ll a = ccw(x1, y1, x2, y2, x3, y3);
    ll b = ccw(x1, y1, x2, y2, x4, y4);
    ll c = ccw(x3, y3, x4, y4, x1, y1);
    ll d = ccw(x3, y3, x4, y4, x2, y2);
    printf("%d\n", a < 0 != b < 0 && c < 0 != d < 0);
    return 0;
}