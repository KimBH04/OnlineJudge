n, m, k = map(int, input().split())
r = 0
for i in range(0, k + 1):
    a = (n - i) // 2
    b = m - k + i
    c = a if a < b else b
    r = c if c > r else r
print(r)