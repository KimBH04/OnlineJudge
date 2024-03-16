n, x = map(int, input().split())
v = list(map(int, input().split()))
s = [0] * (n + 1)
for i in range(0, n):
    s[i + 1] = s[i] + v[i]
left, right, m, cnt, = 0, x, 0, 0
while right <= n:
    h = s[right] - s[left]
    if m < h:
        m = h
        cnt = 1
    elif m == h:
        cnt += 1
    left += 1
    right += 1
print(f'{m}\n{cnt}' if m else 'SAD')