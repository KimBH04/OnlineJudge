import sys

sys.setrecursionlimit(10 ** 5 + 1)

n, r, q = map(int, sys.stdin.readline().split())
edges = [[] for _ in range(n + 1)]
children = [0] * (n + 1)

while 1:
    n -= 1
    if n == 0:
        break

    u, v = map(int, sys.stdin.readline().split())
    edges[u].append(v)
    edges[v].append(u)

def dfs(v: int) -> int:
    children[v] = 1
    for n in edges[v]:
        if not children[n]:
            children[v] += dfs(n)
    return children[v]

dfs(r)

while q:
    q -= 1
    u = int(sys.stdin.readline())
    sys.stdout.write(f'{children[u]}\n')