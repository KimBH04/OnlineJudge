#include <stdio.h>

int main() {
    int n, m, t[100000];
    long long int sum = 0L, max = 0L;
    scanf("%d%d", &n, &m);
    for (int i = 0; i < m; i++) {
        scanf("%d", t + i);
        sum += t[i];
    }
    for (int i = m; i < n; i++) {
        if (max < sum) max = sum;
        scanf("%d", t + i);
        sum -= t[i - m];
        sum += t[i];
    }
    printf("%lld", sum > max ? sum : max);
    return 0;
}