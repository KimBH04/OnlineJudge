#include <stdio.h>

int main() {
    int n, dp[100001], max;
    scanf("%d %d", &n, dp);
    max = *dp;
    for (int i = 1; i < n; i++) {
        scanf("%d", dp + i);
        if (dp[i] < dp[i - 1] + dp[i]) {
            dp[i] += dp[i - 1];
        }

        if (max < dp[i]) {
            max = dp[i];
        }
    }
    printf("%d", max);
    return 0;
}