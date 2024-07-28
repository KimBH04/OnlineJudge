from collections import deque

N, L, R = map(int, input().split())
rng = range(N)

countries = [[*map(int, input().split())] + [256] for _ in rng] + [[256] * (N + 1)]

DIR = [(0, 1), (1, 0), (0, -1), (-1, 0)]
cnt = 0
while 1:
    moved = False
    total_locates = []
    v = [[False] * N for _ in rng]
    for i, j in ((i, j) for i in rng for j in rng):
        if v[i][j]:
            continue

        diff1 = abs(countries[i][j] - countries[i + 1][j])
        diff2 = abs(countries[i][j] - countries[i][j + 1])
        if L <= diff1 and diff1 <= R or L <= diff2 and diff2 <= R:
            moved = True
            locates = [(i, j)]
            steps = 1
            v[i][j] = True
            queue = deque([(i, j)])
            while queue:
                r, c = queue.popleft()
                for d in DIR:
                    tr = r + d[0]
                    tc = c + d[1]
                    if 0 <= tr and tr < N and 0 <= tc and tc < N and not v[tr][tc]:
                        diff1 = abs(countries[r][c] - countries[tr][c])
                        diff2 = abs(countries[r][c] - countries[r][tc])
                        if L <= diff1 and diff1 <= R or L <= diff2 and diff2 <= R:
                            v[tr][tc] = True
                            queue.append((tr, tc))
                            locates.append((tr, tc))
                            steps += 1
            to = sum(countries[r][c] for r, c in locates) // steps
            total_locates.append((locates, to))
    for l, t in total_locates:
        for r, c in l:
            countries[r][c] = t

    if not moved:
        break

    cnt += 1
print(cnt)