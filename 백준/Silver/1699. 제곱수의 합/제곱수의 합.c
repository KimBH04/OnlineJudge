#include <stdio.h>
#include <math.h>

int main()
{
    int n, dp[100001];
    scanf("%d", &n);
    for (int i = 1; i <= n; i++)
    {
        double s = sqrt(i);
        if (s == (int)s)
        {
            dp[i] = 1;
            continue;
        }

        dp[i] = __INT_MAX__;
        for (int j = 1; j * 2 <= i; j++)
        {
            int sum = dp[j] + dp[i - j];
            if (dp[i] > sum)
            {
                dp[i] = sum;
            }
        }
    }
    printf("%d", dp[n]);
    return 0;
}