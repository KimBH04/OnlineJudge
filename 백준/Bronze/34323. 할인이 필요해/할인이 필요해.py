n, m, s = map(int, input().split())
a = (m + 1) * s * (100 - n) // 100
b = m * s
print(min(a, b))