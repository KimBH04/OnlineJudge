#include <stdio.h>

int main()
{
    int n, m, a, sum = 0;
    long long int cnt = 0, mod_cnt[1000] = {1};
    scanf("%d%d", &n, &m);
    while (n--)
    {
        scanf("%d", &a);
        cnt += mod_cnt[sum = (sum + a) % m]++;
    }
    printf("%lld", cnt);
    return 0;
}