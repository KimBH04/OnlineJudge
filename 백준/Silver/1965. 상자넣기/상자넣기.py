n = int(input()) + 1
boxes = [0] + [*map(int, input().split())]
dp = [0] * n
for i in range(n):
    m = 0
    for j in range(i):
        if boxes[j] < boxes[i] and m <= dp[j]:
            m = dp[j]
            dp[i] = m + 1
print(max(dp))