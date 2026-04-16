n = int(input())
x = [*map(int, input().split())]
m = 0
for i in range(n + n):
    if not x[i]:
        continue
    for j in range(i + 1, n + n):
        if x[i] != x[j]:
            continue
        if m < j - (i + 1):
            m = j - (i + 1)
            x[j] = 0
            break
print(m)