n, m = map(int, input().split())
a = [0]
for i in input().split():
    a.append(a[-1] + int(i))

r = 0
left = 0
right = 0
while right <= n:
    s = a[right] - a[left]
    if s > m:
        left += 1
    elif s < m:
        right += 1
    else:
        r += 1
        left += 1
        right += 1

print(r)