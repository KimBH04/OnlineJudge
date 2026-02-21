#include <stdio.h>

int main()
{
    int n, dp[50001] = {0};
    scanf("%d", &n);
    for (int i = 1; i <= n; i++)
    {
        dp[i] = __INT_MAX__;
        for (int j = 1; j * j <= i; j++)
        {
            if (dp[i] > dp[i - j * j] + 1)
            {
                dp[i] = dp[i - j * j] + 1;
            }
        }
    }
    printf("%d", dp[n]);
    return 0;
}