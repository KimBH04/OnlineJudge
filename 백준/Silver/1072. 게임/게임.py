def rate(total: int, count: int) -> int:
    return count * 100 // total

x, y = map(int, input().split())
z = rate(x, y)

if z >= 99:
    print(-1)
    quit()

l = 0
r = x
while l < r:
    m = (l + r) // 2
    if rate(x + m, y + m) > z:
        r = m
    else:
        l = m + 1
print(l)