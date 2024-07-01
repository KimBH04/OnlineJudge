#include <stdio.h>

int main()
{
    int n, m, a, sum = 0;
    long long int cnt = 0, mod_cnt[1000] = {1};
    scanf("%d%d", &n, &m);
    while (n--)
    {
        scanf("%d", &a);
        sum += a;
        sum %= m;
        cnt += mod_cnt[sum]++;
    }
    printf("%lld", cnt);
    return 0;
}