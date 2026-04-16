T = [[[1, 1, 1, 1]], [[1], [1], [1], [1]], [[1, 1], [1, 1]], [[122, 213], [111, 159], [230, 185]], [[217, 95, 117], [182, 175, 234]]]

n, m = map(int, input().split())
p = [[*map(int, input().split())] for _ in range(n)]
score = 0
for t in T:
    h = len(t)
    w = len(t[0])
    for i in range(n - h + 1):
        for j in range(m - w + 1):
            current = [0] * 8
            for k in range(h):
               for l in range(w):
                   o = 0
                   while (t[k][l] >> o) > 0:
                       current[o] += p[i + k][j + l] * ((t[k][l] >> o) & 1)
                       o += 1
            q = max(current)
            if score < q:
                score = q
print(score)