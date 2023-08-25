a, b = map(int, input().split())
if a < b:
    print(-1)
else:
    n = (a + b) // 2
    m = n - b
    if n + m == a and n - m == b:
        print(n, m)
    else:
        print(-1)