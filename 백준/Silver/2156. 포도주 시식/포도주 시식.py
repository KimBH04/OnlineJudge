n = int(input())
w = [int(input()) for _ in range(n)]
if n < 2:
    print(w[0])
    exit(0)

if n < 3:
    print(w[0] + w[1])
    exit(0)

d = [0] * n
d[0] = w[0]
d[1] = w[0] + w[1]
d[2]  = max(w[0] + w[1], w[0] + w[2], w[1] + w[2])
for i in range(3, n):
    d[i] = max(d[i - 1], w[i] + d[i - 2], w[i] + w[i - 1] + d[i - 3])

print(d[-1])