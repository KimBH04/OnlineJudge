MOD = 10**9+7

def multi(a, b):
    return [[(((a[0][0] % MOD) * (b[0][0] % MOD)) % MOD + ((a[0][1] % MOD) * (b[1][0] % MOD)) % MOD) % MOD,
             (((a[0][0] % MOD) * (b[0][1] % MOD)) % MOD + ((a[0][1] % MOD) * (b[1][1] % MOD)) % MOD) % MOD], 
            [(((a[1][0] % MOD) * (b[0][0] % MOD)) % MOD + ((a[1][1] % MOD) * (b[1][0] % MOD)) % MOD) % MOD,
             (((a[1][0] % MOD) * (b[0][1] % MOD)) % MOD + ((a[1][1] % MOD) * (b[1][1] % MOD)) % MOD) % MOD]]

def power(base, p):
    result = [[1, 0], [0, 1]]
    while p:
        if p % 2:
            result = multi(result, base)
        base = multi(base, base)
        p //= 2
    return result

print(power([[0, 1], [1, 1]], int(input()) - 1)[1][1])