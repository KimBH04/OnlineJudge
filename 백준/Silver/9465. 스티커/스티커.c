#include <stdio.h>
#define max(a,b) (((a) > (b)) ? (a) : (b))

int main() {
    int t; scanf("%d", &t);
    while (t--) {
        int n, sticker[2][100001], dp[2][100001] = {{0,},};
        scanf("%d", &n);
        if (n == 1) {
            int a, b;
            scanf("%d%d", &a, &b);
            printf("%d\n", max(a, b));
            continue;
        }
        for (int i = 0; i < n; i++) {
            scanf("%d", sticker[0] + i);
        }
        scanf("%d%d", sticker[1], sticker[1] + 1);
        dp[0][0] = sticker[0][0];
        dp[1][0] = sticker[1][0];
        dp[0][1] = sticker[0][1] + sticker[1][0];
        dp[1][1] = sticker[1][1] + sticker[0][0];
        for (int i = 2; i < n; i++) {
            scanf("%d", sticker[1] + i);
            dp[0][i] = sticker[0][i] + max(dp[1][i - 1], dp[1][i - 2]);
            dp[1][i] = sticker[1][i] + max(dp[0][i - 1], dp[0][i - 2]);
        }
        printf("%d\n", max(dp[0][n - 1], dp[1][n - 1]));
    }
    return 0;
}