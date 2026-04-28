d = [(1, 0), (-1, 0), (0, 1), (0, -1)]

def solution(maps):
    n, m = len(maps), len(maps[0])
    queue = [(0, 0)]
    v = [[-1] * m for _ in range(n)]
    v[0][0] = 1
    while queue:
        r, c = queue[0]
        queue.remove((r, c))
        for d1, d2 in d:
            tr = r + d1
            tc = c + d2
            if 0 <= tr < n and 0 <= tc < m and maps[tr][tc] and v[tr][tc] == -1:
                queue.append((tr, tc))
                v[tr][tc] = v[r][c] + 1
    return v[n - 1][m - 1]