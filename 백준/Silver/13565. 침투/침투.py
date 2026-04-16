from collections import deque
DIR = [(1, 0), (0, 1), (-1, 0), (0, -1)]

m, n = map(int, input().split())
field = [[*map(int, input())] for _ in range(m)]

i = [(0, j) for j in range(n) if field[0][j] == 0]
v = [[0] * n for _ in range(m)]
for _, j in i: v[0][j] = 1
q = deque(i)
while q:
    e = q.popleft()
    for d in DIR:
        tr = e[0] + d[0]
        tc = e[1] + d[1]
        if 0 <= tr < m and 0 <= tc < n and not field[tr][tc] | v[tr][tc]:
            v[tr][tc] = 1
            q.append((tr, tc))

print('YES' if any(v[-1]) else 'NO')