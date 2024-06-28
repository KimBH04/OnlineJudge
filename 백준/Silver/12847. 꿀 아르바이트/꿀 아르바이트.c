#include <stdio.h>

int main() {
    int n, m, t[100000];
    long long int sum = 0L, max = 0L;
    scanf("%d%d", &n, &m);
    for (int i = 0; i < n; i++) {
        if (i >= m) {
            if (max < sum) max = sum;
            sum -= t[i - m];
        }
        scanf("%d", t + i);
        sum += t[i];
    }
    printf("%lld", sum > max ? sum : max);
    return 0;
}