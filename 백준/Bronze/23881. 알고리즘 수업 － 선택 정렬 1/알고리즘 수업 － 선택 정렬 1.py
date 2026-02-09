n, k = map(int, input().split())
a = [*map(int, input().split())]
cnt = 0
for last in range(n, 0, -1):
    m = 0
    idx = 0
    for i in range(last):
        if m < a[i]:
            m = a[i]
            idx = i
    if last != idx + 1:
        cnt += 1
        if cnt == k:
            print(a[last - 1], a[idx])
            exit(0)
        (a[idx], a[last - 1]) = (a[last - 1], a[idx])
print(-1)