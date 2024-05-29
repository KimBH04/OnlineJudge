from sys import stdin as r, stdout as w

lines = r.readlines()
n = int(lines[0])
xy = [(0, 0)] * n
for i in range(n):
    xy[i] = tuple(map(int, lines[i + 1].split()))
for u, v in sorted(xy):
    w.write(f'{u} {v}\n')