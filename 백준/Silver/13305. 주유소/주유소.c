#include <stdio.h>
typedef long long int ll;

int main() {
    ll n, prices[100001] = { 0L, }, min = 1000000000L, x, result = 0L;
    scanf("%lld", &n);
    for (ll i = 0L; i < n - 1; i++) {
        scanf("%lld", prices + i);
    }
    for (ll i = 0L; i < n; i++) {
        scanf("%lld", &x);
        if (min > x) {
            min = x;
        }
        result += min * prices[i];
    }
    printf("%lld", result);
    return 0;
}