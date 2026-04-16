n = int(input())
C = {}
while n > 0:
    n -= 1
    c = int(input())
    if c in C:
        C[c] += 1
    else:
        C[c] = 1
print(-max([(j, -i) for i, j in C.items()])[1])