n, m, k = map(int, input().split())

f = [1]
for num in range(n + m):
    f.append(f[num] * (num + 1))

if f[-1] // (f[n] * f[m]) < k:
    print(-1)
    exit(0)

result = []
while n > 0 and m > 0:
    use_a = f[n + m - 1] // (f[n - 1] * f[m])
    if use_a < k:
        result.append('z')
        k -= use_a
        m -= 1
    else:
        result.append('a')
        n -= 1

if n == 0:
    result += ['z'] * m
else:
    result += ['a'] * n

print(''.join(result))