t = int(input())
while t > 0:
    k, n = map(int, input().split())
    dp = [[0] * 256 for _ in range(32)]
    for i in range(k + 1):
        for j in range(n + 1):
            dp[i][j] = int(i >= j)
    for i in range(1, k + 1):
        temp = [0] * 256
        j = 0
        while dp[i][j]:
            l = 0
            while dp[i - 1][l]:
                temp[j + l] += dp[i][j] * dp[i - 1][l]
                l += 1
            j += 1
        j = 0
        while temp[j]:
            dp[i][j] = temp[j]
            j += 1
    print(dp[k][n])
    t -= 1