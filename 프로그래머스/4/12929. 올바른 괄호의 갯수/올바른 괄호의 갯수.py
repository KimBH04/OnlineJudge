def solution(n):
    dp = [1, 1, 2, 5]
    for i in range(4, n + 1):
        dp += [0]
        for j in range(i):
            dp[i] += dp[j] * dp[i - j - 1]
    return dp[n]