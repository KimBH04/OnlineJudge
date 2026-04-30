MOD = 1000000007

def solution(m, n, puddles):
    loc = [[0] * (m + 1) for _ in range(n + 1)]
    loc[1][1] = 1
    for puddle in puddles:
        loc[puddle[1]][puddle[0]] = -1
    for i in range(1, n + 1):
        for j in range(1, m + 1):
            if i == 1 and j == 1:
                continue
            if loc[i][j] == -1:
                loc[i][j] = 0
                continue
            loc[i][j] = (loc[i - 1][j] % MOD + loc[i][j - 1] % MOD) % MOD
    return loc[n][m]